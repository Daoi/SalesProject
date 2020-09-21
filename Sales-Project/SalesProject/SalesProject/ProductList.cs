using System;
using System.Collections.Generic;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    // Models an internal list of products
    // Not used in our project
    [Serializable()] public class ProductList
    {
        Dictionary<string, Product> productList;

        public ProductList()
        {
            productList = new Dictionary<string, Product>();
        }

        public bool addProduct(string upc, Product item)
        {
            if(productList.ContainsKey(upc))
                return false;

            productList.Add(upc, item);
            return true;

        }

        public bool GetProductByUPC(string upc, out Product item) {
            if (productList.ContainsKey(upc)) {
                item = productList[upc];
                return true;
            }
            else
            {
                item = null;
                return false;
            }
        }

        public bool RemoveProductByUPC(string upc)
        {
            if (productList.ContainsKey(upc))
            {
                productList.Remove(upc);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}