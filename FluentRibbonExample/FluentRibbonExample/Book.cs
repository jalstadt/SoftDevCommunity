using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbonExample
{
    public class Book
    {
        public Book(string name, string isbn, string price)
        {
            Name = name;
            ISBN = isbn;
            Price = price;

        }

        private string _name;
        public string Name
        {
            get 
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                }
            }
        }
        private string _isbn;
        public string ISBN
        {
            get
            {
                return _isbn;
            }
            set
            {
                if (_isbn != value)
                {
                    _isbn = value;
                }
            }
        }
        private string _price;
        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price != value)
                {
                    _price = value;
                }
            }
        }
    }
}
