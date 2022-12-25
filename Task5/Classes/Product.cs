using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Classes
{
    internal class Product
    {
        public Product(double price, string country, string name, string date, string description)
        {
            Price = price;
            Country = country;
            Name = name;
            Date = date;
            Description = description;
        }
        public virtual string[] GetData()
        {
            string[] row = {Price.ToString(), Country, Name, Date, Description };
            return row;
        }
        public double Price { get; }
        public string Country { get; }
        public string Name { get; }
        public string Date { get; }
        public string Description { get; }
    }
}
