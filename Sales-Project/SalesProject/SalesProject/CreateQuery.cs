using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    //Class that handles creating SQL statements for the data base manager class insert commands
    //Essentially just make sure everything has the right data type
    public static class CreateQuery
    {

        public static bool CreateProductQuery(Object product, ref int upc, ref string title, ref decimal price, ref int quantity, ref string productType)
        {

            try
            {
                string[] productData = product.ToString().Split('|');
                upc = int.Parse(productData[0]);
                title = productData[1];
                price = decimal.Parse(productData[2].TrimStart('$'));
                quantity = int.Parse(productData[3]);
                productType = product.GetType().ToString().Split('.')[1].Trim();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool CreateBookCISQuery(BookCIS product, ref string isbn, ref string author, ref int pages, ref string CISArea)
        {
            try
            {
                string[] productData = product.ToString().Split('|');
                isbn = productData[4];
                author = productData[5];
                pages = int.Parse(productData[6]);
                CISArea = productData[7];
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool CreateCDChamberQuery(CDChamber product, ref string instrumentList)
        {
            try
            {
                string[] productData = product.ToString().Split('|');

                instrumentList = productData[6];
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool CreateCDOrchestraQuery(CDOrchestra product, ref string conductor )
        {
            try
            {
                string[] productData = product.ToString().Split('|');
                conductor = productData[6];
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CreateDVDQuery(DVD product, ref string leadActor, ref string date, ref int runTime)
        {
            try
            {
                string[] productData = product.ToString().Split('|');
                leadActor = productData[4];
                date = productData[5];
                runTime = int.Parse(productData[6]);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CreateBookQuery(Book product, ref string isbn, ref string author, ref int pages)
        {
            try
            {
                string[] productData = product.ToString().Split('|');
                isbn = productData[4];
                author = productData[5];
                pages = int.Parse(productData[6]);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CreateCdClassicalQuery(CDClassical product, ref string label, ref string artists)
        {
            try
            {
                string[] productData = product.ToString().Split('|');
                label = productData[4];
                artists = productData[5];
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
