using System;
using System.Text;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    //Model CD Chamber object
    [Serializable()] public class CDChamber : CDClassical
    {
        private string instrumentList;

        public CDChamber(string upc, string title, decimal price, int quantity, string type, string label, string artists, string instrumentList) 
            : base(upc, title, price, quantity, type, label, artists)
        {
            this.instrumentList = instrumentList;
        }


        public override string DisplayProduct()
        {
            StringBuilder sb = new StringBuilder(base.DisplayProduct());
            sb.Append($"Instruments: {instrumentList}");
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append($"{instrumentList}");
            return sb.ToString();
        }
        public string InstrumentList { get { return this.instrumentList; } set { this.instrumentList = value; } }
    }
}   