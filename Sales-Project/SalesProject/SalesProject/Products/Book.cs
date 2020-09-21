using System;
using System.Text;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    //Model book objects
    [Serializable()] public class Book : Product
    {
        private string isbn;
        private string author;
        private int pages;
        public Book(string upc, string title, decimal price, int quantity, string type, string isbn, string author, int pages) 
            : base(upc, title, price, quantity, type)
        {
            this.isbn = isbn;
            this.author = author;
            this.pages = pages;
        }

        public override string DisplayProduct()
        {
            StringBuilder sb = new StringBuilder(base.DisplayProduct());
            sb.Append($"Product Type: Book" +
                      $"\n\rISBN: {isbn}" +
                      $"\n\rAuthor: {author} " +
                      $"\n\rPages: {pages}\r\n");
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append($"{isbn}|{author}|{pages}|");
            return sb.ToString();
        }

        public string Isbn { get { return this.isbn; } set { this.isbn = value; } }
        public string Author { get { return this.author; } set { this.author = value; } }
        public int Pages { get { return this.pages; } set { this.pages = value; } }
    }
}