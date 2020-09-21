using System;
using System.Text;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    [Serializable()] public class DVD : Product
    {
        private string leadActor;
        private DateTime releaseDate;
        private int runTime;

        public DVD(string upc, string title, decimal price, int quantity, string type, string leadActor, DateTime releaseDate, int runTime) 
            : base(upc, title, price, quantity, type)
        {
            this.leadActor = leadActor;
            this.releaseDate = releaseDate;
            this.runTime = runTime;
        }


        public override string DisplayProduct()
        {
            StringBuilder sb = new StringBuilder(base.DisplayProduct());
            sb.Append($"Product Type: DVD " +
                      $"\n\rLead Actor: {leadActor} " +
                      $"\n\rRelease Date: {releaseDate.ToString("dd-MM-yyyy")} " +
                      $"\n\rRuntime: {runTime.ToString()} minutes");
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append($"{leadActor}|{releaseDate.ToString("MM/dd/yyyy")}|{runTime.ToString().Split()[0]}");
            return sb.ToString();
        }

        public string LeadActor { get { return this.leadActor; } set { this.leadActor = value; } }
        public DateTime ReleaseDate { get { return this.releaseDate; } set { this.releaseDate = value; } }
        public int RunTime { get { return this.runTime; } set { this.runTime = value; } }
    }
}