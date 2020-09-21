using System;
using System.Text;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    //Model BookCIS objects
    [Serializable()] public class BookCIS : Book
    {
        private string CISArea;

        public BookCIS(string upc, string title, decimal price, int quantity, string type, string isbn, string author, int pages, string CISArea) 
            : base(upc, title, price, quantity, type, isbn, author, pages)
        {
            this.CISArea = CISArea;
        }

        public override string DisplayProduct()
        {
            StringBuilder sb = new StringBuilder(base.DisplayProduct());
            sb.Append($"CIS Area: {CISArea}");
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append($"{CISArea}");
            return sb.ToString();
        }

        public string CISAREA { get { return this.CISArea; } set { this.CISArea = value; } }
    }
}