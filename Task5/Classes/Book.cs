using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Classes
{
    internal class Book : Product
    {
        public Book(int numberOfPages, string publishingHouse, string authors,
            double price, string country, string name, string date, string description) :
            base(price, country, name, date, description)
        {
            NumberOfPages = numberOfPages;
            PublishingHouse = publishingHouse;
            Authors = authors;
        }
        public override string[] GetData()
        {
            string[] row = { Price.ToString(), Country, Name, Date, Description,
            NumberOfPages.ToString(), PublishingHouse, Authors};
            return row;
        }
        public int NumberOfPages { get; }
        public string PublishingHouse { get; }
        public string Authors { get; }
    }
}
