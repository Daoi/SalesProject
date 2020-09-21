using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    // Class contains all of the database operation methods for delete, insert, and update
    class DatabaseManager
    {
        string strConnection = "";

        public DatabaseManager()
        {
            string path = Path.GetFullPath("ProductDB-2.accdb");
            strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" + $"Data Source = {path}";
        }

        //INSERT METHODS BEGIN
        //All the insert methods work in a similar way.
        //InsertProduct is first called on any product object, that object is treated as a product by the method.
        //The method will retrieve all the product fields, create a SQL statement for them, and then insert them
        //It will then call the appropriate method for inserting the subclass information into the database

        public bool InsertProduct(object product)
        {
            int upc = 0;
            decimal price = 0.00m;
            string title = "";
            int quantity = 0;
            string productType = "";

            string strInsertProduct = "INSERT INTO Product (fldUPC, fldPrice, fldTitle, fldQuantity, fldProductType) " +
            $"VALUES(@upc,@price,@title,@quantity,@productType)";
            if (CreateQuery.CreateProductQuery(product, ref upc, ref title, ref price, ref quantity, ref productType))
            {
                OleDbConnection myConnection = new OleDbConnection(strConnection);
                OleDbCommand myCommand = new OleDbCommand();
                myCommand.CommandText = strInsertProduct;
                myCommand.CommandType = CommandType.Text;
                myCommand.Connection = myConnection;
                myCommand.Parameters.Add(new OleDbParameter("@upc", upc));
                myCommand.Parameters.Add(new OleDbParameter("@price", price));
                myCommand.Parameters.Add(new OleDbParameter("@title", title));
                myCommand.Parameters.Add(new OleDbParameter("@quantity", quantity));
                myCommand.Parameters.Add(new OleDbParameter("@productType", productType));


                OleDbDataReader myDataReader;
                try
                {
                    myConnection.Open();
                    myDataReader = myCommand.ExecuteReader();
                    myDataReader.Close();
                    if(string.Equals(productType, "BookCIS") || string.Equals(productType, "Book"))
                    {
                        if (InsertBook((Book)product, upc, productType))
                            return true;
                        else
                        {
                            MessageBox.Show("Book Data Invalid");
                            return false;
                        }      
                    }
                    else if(string.Equals(productType, "DVD"))
                    {
                        if (InsertDVD((DVD)product, upc))
                            return true;
                        else
                        {
                            MessageBox.Show("Dvd Data Invalid");
                            return false;
                        }
                    }
                    else if (string.Equals(productType, "CDChamber") || string.Equals(productType, "CDOrchestra"))
                    {
                        if (InsertCDClassical((CDClassical)product, upc, productType))
                            return true;
                        else
                        {
                            MessageBox.Show("CD Classical Data Invalid");
                            return false;
                        }

                    }

                    return false;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("There was an Insert Product error: " + ex.Message,
                        "Product Insert Failed", MessageBoxButtons.OK);
                    return false; // returns false if Insert was unsuccessful
                }
                finally
                {
                    myConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Product Data Invalid");
                return false;
            }

        }//

        public bool InsertBook(Book book , int upc, string productType)
        {
            string isbn = "";
            string author = "";
            int pages = 0;
            string strInsertBook = "INSERT INTO Book (fldUPC, fldISBN, fldAuthor, fldPages) " + "VALUES(@upc,@ISBN,@Author,@Pages)";

            if (CreateQuery.CreateBookQuery(book, ref isbn, ref author, ref pages))
            {

                OleDbConnection myConnection = new OleDbConnection(strConnection);
                OleDbCommand bookInsert = new OleDbCommand();
                bookInsert.CommandText = strInsertBook;
                bookInsert.CommandType = CommandType.Text;
                bookInsert.Connection = myConnection;
                bookInsert.Parameters.Add(new OleDbParameter("@upc", upc));
                bookInsert.Parameters.Add(new OleDbParameter("@ISBN", isbn));
                bookInsert.Parameters.Add(new OleDbParameter("@Author", author));
                bookInsert.Parameters.Add(new OleDbParameter("@ISBN", pages));

                try
                {
                    myConnection.Open();
                    bookInsert.ExecuteNonQuery();
                    if (string.Equals(productType, "BookCIS"))
                    {
                        if (InsertBookCIS((BookCIS)book, upc))
                            return true;
                        else
                        {
                            MessageBox.Show("Invalid BookCIS Data");
                            return false; 
                        }
                    }
                    return true; // returns true if Insert was successful
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("There was an Insert Book error: " + ex.Message,
                        "Book Insert Failed", MessageBoxButtons.OK);
                    return false; // returns false if Insert was unsuccessful
                }
                finally
                {
                    myConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Book Data Invalid");
                return false;
            }
        }

        public bool InsertCDClassical(CDClassical cd, int upc, string productType)
        {
            string label = "";
            string artists = "";
            string strInsertCDClassical = "INSERT INTO CDClassical (fldUPC, fldLabel, fldArtists) " + "VALUES(@upc,@Label,@Artists)";

            if (CreateQuery.CreateCdClassicalQuery(cd, ref label, ref artists))
            {

                OleDbConnection myConnection = new OleDbConnection(strConnection);
                OleDbCommand cdClassicalInsert = new OleDbCommand();
                //CDClassical command
                cdClassicalInsert.CommandText = strInsertCDClassical;
                cdClassicalInsert.CommandType = CommandType.Text;
                cdClassicalInsert.Connection = myConnection;
                cdClassicalInsert.Parameters.Add(new OleDbParameter("@upc", upc));
                cdClassicalInsert.Parameters.Add(new OleDbParameter("@Label", label));
                cdClassicalInsert.Parameters.Add(new OleDbParameter("@Artists", artists));

                try
                {
                    myConnection.Open();
                    cdClassicalInsert.ExecuteNonQuery();                    
                    if (string.Equals(productType, "CDOrchestra"))
                    {
                        if (InsertCDOrchestra((CDOrchestra)cd, upc))
                            return true;
                        else
                            return false;
                    }
                    else if (string.Equals(productType, "CDChamber")) {
                        if (InsertCDChamber((CDChamber)cd, upc))
                            return true;
                        else
                            return false;
                    }

                    return true; // returns true if Insert was successful
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("There was an Insert CDClassical error: " + ex.Message,
                        "CDClassical Insert Failed", MessageBoxButtons.OK);
                    return false; // returns false if Insert was unsuccessful
                }
                finally
                {
                    myConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("CDClassical Data Invalid");
                return false;
            }
        }

        public bool InsertBookCIS(BookCIS book, int upc)
        {
            string isbn = "";
            string author = "";
            int pages = 0;
            string CISArea = "";
            string strInsertBookCIS = "INSERT INTO BookCIS (fldUPC, fldCISArea) " + "VALUES(@upc,@CISArea)";

            if (CreateQuery.CreateBookCISQuery(book, ref isbn, ref author, ref pages, ref CISArea))
            {

                OleDbConnection myConnection = new OleDbConnection(strConnection);
                OleDbCommand bookCISInsert = new OleDbCommand();
                //Book CIS Table Command
                bookCISInsert.CommandText = strInsertBookCIS;
                bookCISInsert.CommandType = CommandType.Text;
                bookCISInsert.Connection = myConnection;
                bookCISInsert.Parameters.Add(new OleDbParameter("@upc", upc));
                bookCISInsert.Parameters.Add(new OleDbParameter("@price", CISArea));
                //Book Table Command

                try
                {
                    myConnection.Open();
                    bookCISInsert.ExecuteNonQuery();
                    return true; // returns true if Insert was successful
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("There was an Insert BookCIS error: " + ex.Message,
                        "BookCIS Insert Failed", MessageBoxButtons.OK);
                    return false; // returns false if Insert was unsuccessful
                }
                finally
                {
                    myConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("BookCIS Data Invalid");
                return false;
            }
        }

        public bool InsertCDOrchestra(CDOrchestra cdo, int upc)
        {
            string conductor = "";
            string strInsertCDOrchestra = "INSERT INTO CDOrchestra (fldUPC, fldConductor) " + "VALUES(@upc,@Conductor)";

            if (CreateQuery.CreateCDOrchestraQuery(cdo, ref conductor))
            {

                    OleDbConnection myConnection = new OleDbConnection(strConnection);
                    OleDbCommand cdOrchestraInsert = new OleDbCommand();
                    //CD orchestra Command
                    cdOrchestraInsert.CommandText = strInsertCDOrchestra;
                    cdOrchestraInsert.CommandType = CommandType.Text;
                    cdOrchestraInsert.Connection = myConnection;
                    cdOrchestraInsert.Parameters.Add(new OleDbParameter("@upc", upc));
                    cdOrchestraInsert.Parameters.Add(new OleDbParameter("@Conductor", conductor));
                    try
                    {
                        myConnection.Open();
                        cdOrchestraInsert.ExecuteNonQuery();
                        return true; // returns true if Insert was successful
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("There was an CDO Product error: " + ex.Message,
                            "CDO Insert Failed", MessageBoxButtons.OK);
                        return false; // returns false if Insert was unsuccessful
                    }
                    finally
                    {
                        myConnection.Close();
                    }
                }
            else
            {
                MessageBox.Show("Product CDO Invalid");
                return false;
            }
        }

        public bool InsertCDChamber(CDChamber cdc, int upc)
        {
            string instrumentList = "";
            string strInsertCDOrchestra = "INSERT INTO CDChamber(fldUPC, fldInstrumentList) " + "VALUES(@upc,@InstrumentList)";

            if (CreateQuery.CreateCDChamberQuery(cdc, ref instrumentList))
            {

                OleDbConnection myConnection = new OleDbConnection(strConnection);
                OleDbCommand cdChamber = new OleDbCommand();
                //CD orchestra Command
                cdChamber.CommandText = strInsertCDOrchestra;
                cdChamber.CommandType = CommandType.Text;
                cdChamber.Connection = myConnection;
                cdChamber.Parameters.Add(new OleDbParameter("@upc", upc));
                cdChamber.Parameters.Add(new OleDbParameter("@InstrumentList", instrumentList));
                try
                {
                    myConnection.Open();
                    cdChamber.ExecuteNonQuery();
                    return true; // returns true if Insert was successful
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("There was an Insert CDC error: " + ex.Message,
                        "CDC Insert Failed", MessageBoxButtons.OK);
                    return false; // returns false if Insert was unsuccessful
                }
                finally
                {
                    myConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("CDC Data Invalid");
                return false;
            }
        }


        public bool InsertDVD(DVD dvd, int upc)
        {
            string leadActor = "";
            int runTime = 0;
            string date = "";
            string strInsertDvd = "INSERT INTO DVD (fldUPC, fldLeadActor, fldReleaseDate, fldRunTime) " + "VALUES(@upc,@LeadActor,@ReleaseDate,@RunTime)";

            if (CreateQuery.CreateDVDQuery(dvd, ref leadActor, ref date, ref runTime))
            {
                OleDbConnection myConnection = new OleDbConnection(strConnection);
                OleDbCommand DVDInsert = new OleDbCommand();
                //Book CIS Table Command
                DVDInsert.CommandText = strInsertDvd;
                DVDInsert.CommandType = CommandType.Text;
                DVDInsert.Connection = myConnection;
                DVDInsert.Parameters.Add(new OleDbParameter("@upc", upc));
                DVDInsert.Parameters.Add(new OleDbParameter("@LeadActor", leadActor));
                var param = DVDInsert.Parameters.Add(new OleDbParameter("@ReleaseDate", date));
                param.OleDbType = OleDbType.Date;
                DVDInsert.Parameters.Add(new OleDbParameter("@RunTime", runTime));

                try
                {
                    myConnection.Open();
                    DVDInsert.ExecuteNonQuery();
                    return true; // returns true if Insert was successful
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("There was an Insert DVD error: " + ex.Message,
                        "Product DVD Failed", MessageBoxButtons.OK);
                    return false; // returns false if Insert was unsuccessful
                }
                finally
                {
                    myConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Product DVD Invalid");
                return false;
            }
        }

        //End Insert methods

        // Method that checks for existence of product specified by input upc
        public bool FindProduct(string upc)
        {
            string strFindProduct = "SELECT 1 FROM Product WHERE fldUPC=" + upc;
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strFindProduct, myConnection);
            OleDbDataReader myDataReader;
            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows)
                {
                    return true;
                }
                return false;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Product search error occured: " + ex.Message, "Product Find Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
                return false;
            }
        }

        // Method that retrieves product information from db tables and returns product object
        public Product GetProduct(string upc, out bool success)
        {
            string strGetProduct = "SELECT * FROM Product WHERE fldUPC=" + upc;
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strGetProduct, myConnection);
            OleDbDataReader pr;
            try
            {
                myConnection.Open();
                string productType = GetProductType(upc, myConnection);
                pr = myCommand.ExecuteReader();
                pr.Read();
                // Checking if Book or BookCIS
                if (productType == "Book" || productType == "BookCIS")
                {
                    strGetProduct = "SELECT * FROM Book WHERE fldUPC=" + upc;
                    OleDbCommand bookCommand = new OleDbCommand(strGetProduct, myConnection);
                    OleDbDataReader br;
                    try
                    {
                        br = bookCommand.ExecuteReader();
                        br.Read();
                        // Checking if BookCIS
                        if (productType == "BookCIS")
                        {
                            strGetProduct = "SELECT * FROM BookCIS WHERE fldUPC=" + upc;
                            OleDbCommand bookCISCommand = new OleDbCommand(strGetProduct, myConnection);
                            OleDbDataReader bcr;
                            try
                            {
                                bcr = bookCISCommand.ExecuteReader();
                                bcr.Read();
                                BookCIS bookCIS = new BookCIS(pr["fldUPC"].ToString(), pr["fldTitle"].ToString(), decimal.Parse(pr["fldPrice"].ToString()), Int32.Parse(pr["fldQuantity"].ToString()), "Book", br["fldISBN"].ToString(), br["fldAuthor"].ToString(), Int32.Parse(br["fldPages"].ToString()), bcr["fldCISArea"].ToString());
                                success = true;
                                myConnection.Close();
                                return bookCIS;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("BookCIS get error occured: " + ex.Message, "BookCIS Get Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } // End BookCIS if
                        else
                        {
                            // return regular book if not BookCIS
                            Book book = new Book(pr["fldUPC"].ToString(), pr["fldTitle"].ToString(), decimal.Parse(pr["fldPrice"].ToString()), Int32.Parse(pr["fldQuantity"].ToString()), "Book", br["fldISBN"].ToString(), br["fldAuthor"].ToString(), Int32.Parse(br["fldPages"].ToString()));
                            success = true;
                            myConnection.Close();
                            return book;
                        }  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Book get error occured: " + ex.Message, "Book Get Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } // End Book & BookCIS if
                else if (productType == "DVD")
                {
                    strGetProduct = "SELECT * FROM DVD WHERE fldUPC=" + upc;
                    OleDbCommand DVDCommand = new OleDbCommand(strGetProduct, myConnection);
                    OleDbDataReader dr;
                    try
                    {
                        dr = DVDCommand.ExecuteReader();
                        dr.Read();
                        DVD dvd = new DVD(pr["fldUPC"].ToString(), pr["fldTitle"].ToString(), decimal.Parse(pr["fldPrice"].ToString()), Int32.Parse(pr["fldQuantity"].ToString()), "DVD", dr["fldLeadActor"].ToString(), DateTime.Parse(dr["fldReleaseDate"].ToString()), Int32.Parse(dr["fldRunTime"].ToString()));
                        success = true;
                        myConnection.Close();
                        return dvd;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("DVD get error occured: " + ex.Message, "DVD Get Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } // End DVD if
                else
                {
                    // Must be CDChamber or CDOrchestra
                    strGetProduct = "SELECT * FROM CDClassical where fldUPC=" + upc;
                    OleDbCommand CDClassicalCommand = new OleDbCommand(strGetProduct, myConnection);
                    OleDbDataReader cdr;
                    try
                    {
                        cdr = CDClassicalCommand.ExecuteReader();
                        cdr.Read();
                        if (productType == "CDChamber")
                        {
                            strGetProduct = "SELECT * FROM CDChamber where fldUPC=" + upc;
                            OleDbCommand CDChamberCommand = new OleDbCommand(strGetProduct, myConnection);
                            OleDbDataReader cdcr;
                            try
                            {
                                cdcr = CDChamberCommand.ExecuteReader();
                                cdcr.Read();
                                CDChamber cdchamber = new CDChamber(pr["fldUPC"].ToString(), pr["fldTitle"].ToString(), decimal.Parse(pr["fldPrice"].ToString()), Int32.Parse(pr["fldQuantity"].ToString()), "CDChamber", cdr["fldLabel"].ToString(), cdr["fldArtists"].ToString(), cdcr["fldInstrumentList"].ToString());
                                success = true;
                                myConnection.Close();
                                return cdchamber;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("CDChamber get error occured: " + ex.Message, "CDChamber Get Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        // Must be CDOrchestra
                        else
                        {
                            strGetProduct = "SELECT * FROM CDOrchestra where fldUPC=" + upc;
                            OleDbCommand CDOrchestraCommand = new OleDbCommand(strGetProduct, myConnection);
                            OleDbDataReader cdor;
                            try
                            {
                                cdor = CDOrchestraCommand.ExecuteReader();
                                cdor.Read();
                                CDOrchestra cdorchestra = new CDOrchestra(pr["fldUPC"].ToString(), pr["fldTitle"].ToString(), decimal.Parse(pr["fldPrice"].ToString()), Int32.Parse(pr["fldQuantity"].ToString()), "CDOrchestra", cdr["fldLabel"].ToString(), cdr["fldArtists"].ToString(), cdor["fldConductor"].ToString());
                                success = true;
                                myConnection.Close();
                                return cdorchestra;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("CDOrchestra get error occured: " + ex.Message, "CDOrchestra Get Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("CDClassical get error occured: " + ex.Message, "CDClassical Get Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product get error occured: " + ex.Message, "Product Get Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConnection.Close();
            }

            // Error's occured when retrieving data from db
            // Return placeholder product and set success flag to false
            success = false;
            return new Book("", "", 0m, 0, "", "", "", 0);
        }

        // Method that retrieves product type attribute from database and return's value
        private string GetProductType(string upc, OleDbConnection connection)
        {
            string strGetProductType = "SELECT fldProductType FROM Product WHERE fldUPC=" + upc;
            OleDbCommand myCommand = new OleDbCommand(strGetProductType, connection);
            OleDbDataReader pr;
            string productType;
            try
            {
                pr = myCommand.ExecuteReader();
                pr.Read();
                productType = pr["fldProductType"].ToString();
                return productType;

            }
            catch (OleDbException ex)
            {
                // Error, return empty string
                MessageBox.Show("Product type get error occured: " + ex.Message, "Product Type Get Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        // Main driver for deleting products
        // Calls supporting delete methods depending on tables that need to be deleted from
        public bool DeleteProduct(string upc)
        {
            string strDeleteProduct = "DELETE FROM Product WHERE fldUPC=" + upc;
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strDeleteProduct, myConnection);
            try
            {
                myConnection.Open();
                string productType = GetProductType(upc, myConnection);
                OleDbDataReader reader = myCommand.ExecuteReader();
                if (productType == "Book" || productType == "BookCIS")
                {
                    bool delBook = DeleteBookRecord(upc, myConnection);
                    if (productType == "BookCIS")
                    {
                        bool delBookCIS = DeleteBookCISRecord(upc, myConnection);
                        return delBookCIS;
                    }
                    myConnection.Close();
                    return delBook;
                }
                else if (productType == "DVD")
                {
                    bool delDVD = DeleteDVDRecord(upc, myConnection);
                    return delDVD;
                }
                else
                {
                    // Product type either CDOrchestra or CDChamber
                    bool delCDClassical = DeleteCDClassicalRecord(upc, myConnection);
                    if (productType == "CDChamber")
                    {
                        bool delCDChamber = DeleteCDChamberRecord(upc, myConnection);
                        return delCDChamber;
                    }
                    else
                    {
                        bool delCDOrchestra = DeleteCDOrchestraRecord(upc, myConnection);
                        return delCDOrchestra;
                    }
                }
            }
            catch(Exception ex)
            {
                // Error, return false
                MessageBox.Show("Product delete error occured: " + ex.Message, "Product Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                myConnection.Close();
            }
        }

        // DELETE SUPPORTING METHODS
        // Methods that delete rows from 1 particular product type table that match the passed upc
        // All methods are identical apart from the table they delete from
        private bool DeleteBookRecord(string upc, OleDbConnection connection)
        {
            string strDeleteBook = "DELETE FROM Book WHERE fldUPC=" + upc;
            OleDbCommand myCommand = new OleDbCommand(strDeleteBook, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("Book delete error occured: " + ex.Message, "Book Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool DeleteBookCISRecord(string upc, OleDbConnection connection)
        {
            string strDeleteBookCIS = "DELETE FROM BookCIS WHERE fldUPC=" + upc;
            OleDbCommand myCommand = new OleDbCommand(strDeleteBookCIS, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("BookCIS delete error occured: " + ex.Message, "BookCIS Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool DeleteDVDRecord(string upc, OleDbConnection connection)
        {
            string strDeleteDVD = "DELETE FROM DVD WHERE fldUPC=" + upc;
            OleDbCommand myCommand = new OleDbCommand(strDeleteDVD, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("DVD delete error occured: " + ex.Message, "DVD Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool DeleteCDClassicalRecord(string upc, OleDbConnection connection)
        {
            string strDeleteCDCl = "DELETE FROM CDClassical WHERE fldUPC=" + upc;
            OleDbCommand myCommand = new OleDbCommand(strDeleteCDCl, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("CDClassical delete error occured: " + ex.Message, "CDClassical Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool DeleteCDOrchestraRecord(string upc, OleDbConnection connection)
        {
            string strDeleteCDO = "DELETE FROM CDOrchestra WHERE fldUPC=" + upc;
            OleDbCommand myCommand = new OleDbCommand(strDeleteCDO, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("CDOrchestra delete error occured: " + ex.Message, "CDOrchestra Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool DeleteCDChamberRecord(string upc, OleDbConnection connection)
        {
            string strDeleteCDCh = "DELETE FROM CDChamber WHERE fldUPC=" + upc;
            OleDbCommand myCommand = new OleDbCommand(strDeleteCDCh, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("CDChamber delete error occured: " + ex.Message, "CDChamber Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Main driver for updating product entries
        // Call supporting methods depending on type of product being updated
        public bool UpdateProduct(string upc, Product p)
        {
            string strUpdateProduct = "UPDATE Product SET fldPrice=" + p.Price + ", fldTitle='" + p.Title + "', fldQuantity=" + p.Quantity + ", fldProductType='" + p.Type + "' WHERE fldUPC=" + upc;
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateProduct, myConnection);
            try
            {
                myConnection.Open();
                myCommand.ExecuteReader();
                string productType = p.Type;
                if (productType == "Book" || productType == "BookCIS")
                {
                    bool updateBook = UpdateBook(myConnection, (Book)p);
                    if (productType == "BookCIS")
                    {
                        bool updateBookCIS = UpdateBookCIS(myConnection, (BookCIS)p);
                        myConnection.Close();
                        return updateBookCIS;
                    }
                    return updateBook;
                }
                else if (productType == "DVD")
                {
                    bool updateDVD = UpdateDVD(myConnection, (DVD)p);
                    myConnection.Close();
                    return updateDVD;
                }
                else
                {
                    bool updateCDClassical = UpdateCDClassical(myConnection, (CDClassical)p);
                    if (productType == "CDChamber")
                    {
                        bool updateCDChamber = UpdateCDChamber(myConnection, (CDChamber)p);
                        myConnection.Close();
                        return updateCDChamber; 
                    }
                    else
                    {
                        bool updateCDOrchestra = UpdateCDOrchestra(myConnection, (CDOrchestra)p);
                        myConnection.Close();
                        return updateCDOrchestra;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product update error occured: " + ex.Message, "Product Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
                return false;
            }
        }

        // UPDATE SUPPORTING METHODS
        // Update rows in 1 specific table, specified by the passed product's upc
        // All methods are identical besides the table which they update rows in
        public bool UpdateBook(OleDbConnection connection, Book p)
        {
            string strUpdateBook = "UPDATE Book SET fldISBN='" + p.Isbn + "', fldAuthor='" + p.Author + "', fldPages=" + p.Pages + " WHERE fldUPC=" + p.Upc;
            OleDbCommand myCommand = new OleDbCommand(strUpdateBook, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("Book update error occured: " + ex.Message, "Book Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateBookCIS(OleDbConnection connection, BookCIS p)
        {
            string strUpdateBookCIS = "UPDATE BookCIS SET fldCISArea='" + p.CISAREA + "' WHERE fldUPC=" + p.Upc;
            OleDbCommand myCommand = new OleDbCommand(strUpdateBookCIS, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("BookCIS update error occured: " + ex.Message, "BookCIS Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateDVD(OleDbConnection connection, DVD p)
        {
            string strUpdateDVD = "UPDATE DVD SET fldLeadActor='" + p.LeadActor + "', fldReleaseDate='" + p.ReleaseDate + "', fldRunTime=" + p.RunTime + " WHERE fldUPC=" + p.Upc;
            OleDbCommand myCommand = new OleDbCommand(strUpdateDVD, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("DVD update error occured: " + ex.Message, "DVD Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateCDClassical(OleDbConnection connection, CDClassical p)
        {
            string strUpdateCDClassical = "UPDATE CDClassical SET fldLabel='" + p.Label + "', fldArtists='" + p.Artists + "' WHERE fldUPC=" + p.Upc;
            OleDbCommand myCommand = new OleDbCommand(strUpdateCDClassical, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("CDClassical update error occured: " + ex.Message, "CDClassical Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateCDChamber(OleDbConnection connection, CDChamber p)
        {
            string strUpdateCDChamber = "UPDATE CDChambe SET fldInstrumentList='" + p.InstrumentList + "' WHERE fldUPC=" + p.Upc;
            OleDbCommand myCommand = new OleDbCommand(strUpdateCDChamber, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("CDChamber update error occured: " + ex.Message, "CDChamber Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateCDOrchestra(OleDbConnection connection, CDOrchestra p)
        {
            string strUpdateCDOrchestra = "UPDATE CDOrchestra SET fldConductor='" + p.Conductor + "' WHERE fldUPC=" + p.Upc;
            OleDbCommand myCommand = new OleDbCommand(strUpdateCDOrchestra, connection);
            try
            {
                myCommand.ExecuteReader();
                return true;
            }
            catch (OleDbException ex)
            {
                // Error, return false
                MessageBox.Show("CDOrchestra update error occured: " + ex.Message, "CDOrchestra Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
