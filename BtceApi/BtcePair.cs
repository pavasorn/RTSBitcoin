using System;

namespace BtcE
{
    public enum BtcePair
    {
        btc_usd,
        btc_eur,
        ltc_btc,
        ltc_usd,
        nvc_btc,
        eur_usd,
        Unknown
    }

    public class BtcePairHelper
    {
        public static BtcePair FromString(string s)
        {
            BtcePair ret;
            Enum.TryParse(s.ToLowerInvariant(), out ret);
            return ret;
        }

        public static string ToString(BtcePair v)
        {
            return Enum.GetName(typeof (BtcePair), v).ToLowerInvariant();
        }
    }
}