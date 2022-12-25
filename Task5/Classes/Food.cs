using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace Task5.Classes
{
    internal class Food : Product
    {
        public Food(string expirationDate, int amount, string unit,
            double price, string country, string name, string date, string description) :
            base(price, country, name, date, description)
        {
            ExpirationDate = expirationDate;
            Amount = amount;
            Unit = unit;
        }
        public override string[] GetData()
        {
            string[] row = { Price.ToString(), Country, Name, Date, Description,
            ExpirationDate, Amount.ToString(), Unit};
            return row;
        }
        public string ExpirationDate { get; }
        public int Amount { get; }
        public string Unit { get; }
    }
}
