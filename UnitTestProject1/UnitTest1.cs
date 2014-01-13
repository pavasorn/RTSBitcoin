using System;
using BtcE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RTSBitcoinProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test001_AddCurrency_No_Problems()
        {
            var control = new Control();
            var currencies = control.AddCurrencies();
            var btcepair = new BtcePair();

            foreach (string currency in currencies)
            {
                var a = (BtcePair) Enum.Parse(typeof(BtcePair), currency.ToLower());
            }
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Test002_AddCurrency_Currency_Capital_Letter()
        {
            var control = new Control();
            var currencies = control.AddCurrencies();
            var btcepair = new BtcePair();

            foreach (string currency in currencies)
            {
                var a = (BtcePair)Enum.Parse(typeof(BtcePair), currency);
            }
        }

    }
}
