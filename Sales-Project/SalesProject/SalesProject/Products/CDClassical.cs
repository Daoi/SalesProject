using System;
using System.Text;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    //Model CD Classical Objects
    [Serializable()] public abstract class CDClassical : Product
    {
        private string label;
        private string artists;

        public CDClassical(string upc, string title, decimal price, int quantity, string type, string label, string artists) 
            : base(upc, title, price, quantity, type)
        {
            this.label = label;
            this.artists = artists;
        }

        public override string DisplayProduct()
        {
            StringBuilder sb = new StringBuilder(base.DisplayProduct());
            sb.Append($"Product Type: Classical CD" +
                      $"\r\nLabel: {label}" +
                      $"\r\nArists: {artists}\r\n");
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append($"{label}|{artists}|");
            return sb.ToString();
        }

        public string Artists { get { return this.artists; } set { this.artists = value; } }
        public string Label { get { return this.label; } set { this.label = value; } }
    }
    
}