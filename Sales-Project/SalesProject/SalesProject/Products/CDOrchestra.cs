using System;
using System.Text;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    //Class for modeling CD orchestra objects
    [Serializable()] public class CDOrchestra : CDClassical
    {
        private string conductor;

        public CDOrchestra(string upc, string title, decimal price, int quantity, string type, string label, string artists, string conductor) 
            : base(upc, title, price, quantity, type, label, artists)
        {
            this.conductor = conductor;
        }
        public override string DisplayProduct()
        {
            StringBuilder sb = new StringBuilder(base.DisplayProduct());
            sb.Append($"Conductor: {conductor}");
            return sb.ToString();
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append($"{conductor}");
            return sb.ToString();
        }

        public string Conductor { get { return this.conductor; } set { this.conductor = value; } }
    }
}