using System;
using System.Collections.Generic;

namespace BtcE
{
    public class Order
    {
        public BtcePair Pair { get; set; }
        public TradeType Type { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public UInt32 Timestamp_Created { get; set; }
        public int Status { get; set; }
    }

    public class OrderList
    {
        public int Success { get; set; }
        public Dictionary<string, Order> @return { get; set; }
    }
}