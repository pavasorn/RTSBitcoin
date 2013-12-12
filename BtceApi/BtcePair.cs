using System;

namespace BtcE
{
    public enum BtcePair
    {
        ltc_eur,
        btc_eur,
        ltc_btc,
        eur_usd,
        ltc_usd,
        btc_usd,
        nvc_btc,
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