using System;
using System.Text;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    //Class for modeling Product objects
    [Serializable()] public abstract class Product
    {
        private string upc;
        private decimal price;
        private string title;
        private int quantity;
        private string type;//Keep track of sub classes?

        public Product(string upc, string title, decimal price, int quantity, string type)
        {
            this.upc = upc;
            this.title = title;
            this.price = price;
            this.quantity = quantity;
            this.type = type;

        }
        //Used for displaying the product to users with message boxes. 
        //Subclasses all inherit and override this method with their own, but purpose remains the same
        ////The different methods are all appened into one string.
        public virtual string DisplayProduct()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Product UPC: {upc}" +
                      $"\n\rProduct Name: {title} " +
                      $"\n\rProduct Price: ${price.ToString()}" +
                      $"\n\rProduct Quantity: {quantity.ToString()}\n\r");
            return sb.ToString();
        }
        //Used for creating SQL statement.
        //Subclasses all inherit and override this method with their own, but purpose remains the same
        //The different methods are all appened into one string.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{upc}|{title}|{price}|{quantity}|");    
            return sb.ToString();
        }

        // Getters and setters for all attributes
        // Subclasses all contain same methods for their unique attributes as well
        public string Upc { get { return this.upc; } set { this.upc = value; } }
        public decimal Price { get { return this.price; } set { this.price = value; } }
        public string Title { get { return this.title; } set { this.title = value; } }
        public int Quantity { get { return this.quantity; } set { this.quantity = value; } }
        public string Type { get { return this.type; } set { this.type = value; } }
    }
}