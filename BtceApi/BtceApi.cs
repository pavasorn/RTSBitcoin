/*
 * Base for making api class for btc-e.com
 * DmT
 * 2012
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Newtonsoft.Json.Linq;

namespace BtcE
{
    internal class WebApi
    {
        public static string Query(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Proxy = WebRequest.DefaultWebProxy;
            request.Proxy.Credentials = CredentialCache.DefaultCredentials;
            if (request == null)
                throw new Exception("Non HTTP WebRequest");
            return new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd();
        }
    }

    public class BtceApi
    {
        private readonly HMACSHA512 _hashMaker;
        private readonly string _key;
        private UInt32 _nonce;

        public BtceApi(string key, string secret)
        {
            _key = key;
            _hashMaker = new HMACSHA512(Encoding.ASCII.GetBytes(secret));
            _nonce = UnixTime.Now;
        }

        public UserInfo GetInfo()
        {
            string resultStr = Query(new Dictionary<string, string>
            {
                {"method", "getInfo"}
            });
            JObject result = JObject.Parse(resultStr);
            if (result.Value<int>("success") == 0)
                throw new Exception(result.Value<string>("error"));
            return UserInfo.ReadFromJObject(result["return"] as JObject);
        }

        public TransHistory GetTransHistory(
            int? from = null,
            int? count = null,
            int? fromId = null,
            int? endId = null,
            bool? orderAsc = null,
            DateTime? since = null,
            DateTime? end = null
            )
        {
            var args = new Dictionary<string, string>
            {
                {"method", "TransHistory"}
            };

            if (from != null) args.Add("from", from.Value.ToString());
            if (count != null) args.Add("count", count.Value.ToString());
            if (fromId != null) args.Add("from_id", fromId.Value.ToString());
            if (endId != null) args.Add("end_id", endId.Value.ToString());
            if (orderAsc != null) args.Add("order", orderAsc.Value ? "ASC" : "DESC");
            if (since != null) args.Add("since", UnixTime.GetFromDateTime(since.Value).ToString());
            if (end != null) args.Add("end", UnixTime.GetFromDateTime(end.Value).ToString());
            JObject result = JObject.Parse(Query(args));
            if (result.Value<int>("success") == 0)
                throw new Exception(result.Value<string>("error"));
            return TransHistory.ReadFromJObject(result["return"] as JObject);
        }

        public TradeHistory GetTradeHistory(
            int? from = null,
            int? count = null,
            int? fromId = null,
            int? endId = null,
            bool? orderAsc = null,
            DateTime? since = null,
            DateTime? end = null
            )
        {
            var args = new Dictionary<string, string>
            {
                {"method", "TradeHistory"}
            };

            if (from != null) args.Add("from", from.Value.ToString());
            if (count != null) args.Add("count", count.Value.ToString());
            if (fromId != null) args.Add("from_id", fromId.Value.ToString());
            if (endId != null) args.Add("end_id", endId.Value.ToString());
            if (orderAsc != null) args.Add("order", orderAsc.Value ? "ASC" : "DESC");
            if (since != null) args.Add("since", UnixTime.GetFromDateTime(since.Value).ToString());
            if (end != null) args.Add("end", UnixTime.GetFromDateTime(end.Value).ToString());

            JObject result = JObject.Parse(Query(args));
            if (result.Value<int>("success") == 0)
                throw new Exception(result.Value<string>("error"));
            return TradeHistory.ReadFromJObject(result["return"] as JObject);
        }

        public OrderList GetOrderList(
            int? from = null,
            int? count = null,
            int? fromId = null,
            int? endId = null,
            bool? orderAsc = null,
            DateTime? since = null,
            DateTime? end = null,
            BtcePair? pair = null,
            bool? active = null
            )
        {
            var args = new Dictionary<string, string>
            {
                {"method", "OrderList"}
            };

            if (from != null) args.Add("from", from.Value.ToString());
            if (count != null) args.Add("count", count.Value.ToString());
            if (fromId != null) args.Add("from_id", fromId.Value.ToString());
            if (endId != null) args.Add("end_id", endId.Value.ToString());
            if (orderAsc != null) args.Add("order", orderAsc.Value ? "ASC" : "DESC");
            if (since != null) args.Add("since", UnixTime.GetFromDateTime(since.Value).ToString());
            if (end != null) args.Add("end", UnixTime.GetFromDateTime(end.Value).ToString());
            if (pair != null) args.Add("pair", BtcePairHelper.ToString(pair.Value));
            if (active != null) args.Add("active", active.Value ? "1" : "0");
            JObject result = JObject.Parse(Query(args));
            if (result.Value<int>("success") == 0)
                throw new Exception(result.Value<string>("error"));
            return OrderList.ReadFromJObject(result["return"] as JObject);
        }

        public TradeAnswer Trade(BtcePair pair, TradeType type, decimal rate, decimal amount)
        {
            var args = new Dictionary<string, string>
            {
                {"method", "Trade"},
                {"pair", BtcePairHelper.ToString(pair)},
                {"type", TradeTypeHelper.ToString(type)},
                {"rate", DecimalToString(rate)},
                {"amount", DecimalToString(amount)}
            };
            JObject result = JObject.Parse(Query(args));
            if (result.Value<int>("success") == 0)
                throw new Exception(result.Value<string>("error"));
            return TradeAnswer.ReadFromJObject(result["return"] as JObject);
        }

        public CancelOrderAnswer CancelOrder(int orderId)
        {
            var args = new Dictionary<string, string>
            {
                {"method", "CancelOrder"},
                {"order_id", orderId.ToString()}
            };
            JObject result = JObject.Parse(Query(args));
            if (result.Value<int>("success") == 0)
                throw new Exception(result.Value<string>("error"));
            return CancelOrderAnswer.ReadFromJObject(result["return"] as JObject);
        }

        private string Query(Dictionary<string, string> args)
        {
            args.Add("nonce", GetNonce().ToString());

            string dataStr = BuildPostData(args);
            byte[] data = Encoding.ASCII.GetBytes(dataStr);

            var request = WebRequest.Create(new Uri("https://btc-e.com/tapi")) as HttpWebRequest;
            if (request == null)
                throw new Exception("Non HTTP WebRequest");

            request.Method = "POST";
            request.Timeout = 15000;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            request.Headers.Add("Key", _key);
            request.Headers.Add("Sign", ByteArrayToString(_hashMaker.ComputeHash(data)).ToLower());
            Stream reqStream = request.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            reqStream.Close();
            return new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd();
        }

        private static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }

        private static string BuildPostData(Dictionary<string, string> d)
        {
            var s = new StringBuilder();
            foreach (var item in d)
            {
                s.AppendFormat("{0}={1}", item.Key, HttpUtility.UrlEncode(item.Value));
                s.Append("&");
            }
            if (s.Length > 0) s.Remove(s.Length - 1, 1);
            return s.ToString();
        }

        private UInt32 GetNonce()
        {
            return _nonce++;
        }

        private static string DecimalToString(decimal d)
        {
            return d.ToString(CultureInfo.InvariantCulture);
        }

        public static Depth GetDepth(BtcePair pair)
        {
            string queryStr = string.Format("https://btc-e.com/api/2/{0}/depth", BtcePairHelper.ToString(pair));
            return Depth.ReadFromJObject(JObject.Parse(WebApi.Query(queryStr)));
        }

        public static Ticker GetTicker(BtcePair pair)
        {
            string queryStr = string.Format("https://btc-e.com/api/2/{0}/ticker", BtcePairHelper.ToString(pair));
            return Ticker.ReadFromJObject(JObject.Parse(WebApi.Query(queryStr))["ticker"] as JObject);
        }

        public static List<TradeInfo> GetTrades(BtcePair pair)
        {
            string queryStr = string.Format("https://btc-e.com/api/2/{0}/trades", BtcePairHelper.ToString(pair));
            return JArray.Parse(WebApi.Query(queryStr)).OfType<JObject>().Select(TradeInfo.ReadFromJObject).ToList();
        }

        public static decimal GetFee(BtcePair pair)
        {
            string queryStr = string.Format("https://btc-e.com/api/2/{0}/fee", BtcePairHelper.ToString(pair));
            return JObject.Parse(WebApi.Query(queryStr)).Value<decimal>("trade");
        }
    }

    public class BtceApiV3
    {
        private static string MakePairListString(IEnumerable<BtcePair> pairlist)
        {
            return string.Join("-", pairlist.Select(BtcePairHelper.ToString).ToArray());
        }

        private static string Query(string method, BtcePair[] pairlist, Dictionary<string, string> args = null)
        {
            string pairliststr = MakePairListString(pairlist);
            var sb = new StringBuilder();
            sb.Append("https://btc-e.com/api/3/");
            sb.Append(method);
            sb.Append("/");
            sb.Append(pairliststr);
            if (args != null && args.Count > 0)
            {
                sb.Append("?");
                string[] arr =
                    args.Select(
                        x => string.Format("{0}={1}", HttpUtility.UrlEncode(x.Key), HttpUtility.UrlEncode(x.Value)))
                        .ToArray();
                sb.Append(string.Join("&", arr));
            }
            string queryStr = sb.ToString();
            return WebApi.Query(queryStr);
        }

        private static string QueryIgnoreInvalid(string method, BtcePair[] pairlist,
            Dictionary<string, string> args = null)
        {
            var newargs = new Dictionary<string, string> {{"ignore_invalid", "1"}};
            if (args != null)
                newargs.Concat(args);
            return Query(method, pairlist, newargs);
        }

        private static Dictionary<BtcePair, T> ReadPairDict<T>(JObject o, Func<JContainer, T> valueReader)
        {
            return
                o.OfType<JProperty>()
                    .Select(
                        x =>
                            new KeyValuePair<BtcePair, T>(BtcePairHelper.FromString(x.Name),
                                valueReader(x.Value as JContainer)))
                    .ToDictionary(x => x.Key, x => x.Value);
        }

        private static Dictionary<BtcePair, T> MakeRequest<T>(string method, BtcePair[] pairlist,
            Func<JContainer, T> valueReader, Dictionary<string, string> args = null, bool ignoreInvalid = true)
        {
            string queryresult = ignoreInvalid ? QueryIgnoreInvalid(method, pairlist, args) : Query(method, pairlist, args);
            JObject resobj = JObject.Parse(queryresult);

            if (resobj["success"] != null && resobj.Value<int>("success") == 0)
                throw new Exception(resobj.Value<string>("error"));

            Dictionary<BtcePair, T> r = ReadPairDict(resobj, valueReader);
            return r;
        }

        public static Dictionary<BtcePair, Depth> GetDepth(BtcePair[] pairlist, int limit = 150)
        {
            return MakeRequest("depth", pairlist, x => Depth.ReadFromJObject(x as JObject),
                new Dictionary<string, string> {{"limit", limit.ToString()}});
        }

        public static Dictionary<BtcePair, Ticker> GetTicker(BtcePair[] pairlist)
        {
            return MakeRequest("ticker", pairlist, x => Ticker.ReadFromJObject(x as JObject));
        }

        public static Dictionary<BtcePair, List<TradeInfoV3>> GetTrades(BtcePair[] pairlist, int limit = 150)
        {
            Func<JContainer, List<TradeInfoV3>> tradeInfoListReader =
                (x => x.OfType<JObject>().Select(TradeInfoV3.ReadFromJObject).ToList());
            return MakeRequest("trades", pairlist, tradeInfoListReader,
                new Dictionary<string, string> {{"limit", limit.ToString()}});
        }
    }
}