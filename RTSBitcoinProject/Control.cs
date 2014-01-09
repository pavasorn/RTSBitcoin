﻿using System;
using System.Globalization;
using System.Windows.Forms;
using BtcE;

namespace RTSBitcoinProject
{
    public class Control
    {
        readonly CultureInfo _culture = CultureInfo.InvariantCulture;
        private BtceApi _btceApi;

        public string UpdateBalance()
        {
            _btceApi = new BtceApi(LoginPage.Key, LoginPage.Secret);
            var userInfo = _btceApi.GetInfo();
            if (_btceApi.Equals(null)) return null;

            return userInfo.Funds.Ltc.ToString(_culture) + "LTC";
        }

        public Ticker UpdatePrices(string input)
        {
            return BtceApi.GetTicker(BtcePairHelper.FromString(input));
        }

        public object[] AddCurrencies()
        {
            var currencyComboBox = new ComboBox();
            foreach (var item in Enum.GetValues(typeof(BtcePair)))
                currencyComboBox.Items.Add(item.ToString().ToUpper());

            var items = new object[currencyComboBox.Items.Count];
            currencyComboBox.Items.CopyTo(items,0);
            return items;
        }

        public TradeAnswer Buy(string pairString, decimal operationPrice, decimal amount)
        {
            return _btceApi.Trade(BtcePairHelper.FromString(pairString), TradeType.Buy, operationPrice, amount);
        }
        
        public TradeAnswer Sell(string pairString, decimal operationPrice, decimal amount)
        {
            return _btceApi.Trade(BtcePairHelper.FromString(pairString), TradeType.Sell, operationPrice, amount);
        }
    }
}
