using GroupProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace GroupProject.Main
{
    class clsMainLogic
    {
        #region Attributes
        readonly clsMainSQL SQL;
        /// <summary>
        /// Provides access to the database
        /// </summary>
        readonly clsDataAccess DataBase;
        /// <summary>
        /// Number of return values
        /// </summary>
        int iRet = 0;
        /// <summary>
        /// Holds data from queries
        /// </summary>
        DataSet DataSet;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for clsMainSQL
        /// </summary>
        public clsMainLogic()
        {
            SQL = new clsMainSQL();
            DataBase = new clsDataAccess();
        }
        #endregion

        #region CREATE Methods
        /// <summary>
        /// Accepts an invoice object and inserts it into the Invoices table
        /// </summary>
        /// <param name="invoice"></param>
        public void CreateInvoice(Invoice invoice)
        {
            DataBase.ExecuteNonQuery("INSERT INTO Invoices(InvoiceDate, TotalCost) VALUES('#" + invoice.InvoiceDate.ToString() + "#'," + invoice.TotalCost + ")");
        }

        /// <summary>
        /// Accepts an item object, an invoice number, and a line item number and inserts it into the LineItems table
        /// </summary>
        /// <param name="item"></param>
        /// <param name="invoiceNumber"></param>
        /// <param name="invoiceItemNumber"></param>
        public void CreateLineItem(Item item, int invoiceNumber, int invoiceItemNumber)
        {
            DataBase.ExecuteNonQuery("INSERT INTO LineItems(InvoiceNum, LineItemNum, ItemCode) VALUES('" + invoiceNumber + "', '" + invoiceItemNumber + "', '" + item.ItemCode + "')");
        }
        #endregion

        #region RETRIEVE Methods
        /// <summary>
        /// Gets a list of all the items from the ItemDesc table asd
        /// </summary>
        /// <returns></returns>
        public List<Item> GetItems()
        {
            try
            {
                List<Item> items = new List<Item>();
                DataSet = DataBase.ExecuteSQLStatement(SQL.SelectItems(), ref iRet);
                for (int i = 0; i < iRet; i++)
                {
                    items.Add(new Item { ItemCode = Convert.ToChar(DataSet.Tables[0].Rows[i][0]), ItemDesc = DataSet.Tables[0].Rows[i][1].ToString(), Cost = Convert.ToDouble(DataSet.Tables[0].Rows[i][2]) });
                }
                return items;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    MethodInfo.GetCurrentMethod().DeclaringType.Name +
                    "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Gets a list of all the invoices with a given invoiceNumber from the Invoices table 
        /// </summary>
        /// <param name="invoiceNumber"></param>
        /// <returns></returns>
        public List<Invoice> GetInvoiceByNumber(int invoiceNumber)
        {
            try
            {
                List<Invoice> invoices = new List<Invoice>();
                DataSet = DataBase.ExecuteSQLStatement("SELECT * FROM Invoices WHERE InvoiceNum = " + invoiceNumber, ref iRet);
                for (int i = 0; i < iRet; i++)
                {
                    invoices.Add(new Invoice { InvoiceNum = invoiceNumber, InvoiceDate = (DateTime)DataSet.Tables[0].Rows[i][1], TotalCost = (double)DataSet.Tables[0].Rows[i][2] });
                }
                return invoices;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    MethodInfo.GetCurrentMethod().DeclaringType.Name +
                    "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        #endregion

        #region UPDATE Methods
        #endregion

        #region DELETE Methods
        #endregion
    }
}
