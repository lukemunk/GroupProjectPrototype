using System;

namespace GroupProject.Main
{
    class clsMainSQL
    {
        #region Insert Queries        
        /// <summary>
        /// Returns a query that will insert a line item into the LineItems table
        /// </summary>
        /// <param name="invoiceNumber"></param>
        /// <param name="lineItemNumber"></param>
        /// <param name="itemCode"></param>
        /// <returns></returns>
        public string InsertLineItem(int invoiceNumber, int lineItemNumber, char itemCode)
        {
            return "INSERT INTO LineItems(InvoiceNum, LineItemNum, ItemCode) VALUES (" + invoiceNumber + ", " + lineItemNumber + ", " + "'" + itemCode + "'";
        }

        /// <summary>
        /// Returns a query that will insert an invoice into the Invoices table
        /// </summary>
        /// <param name="date"></param>
        /// <param name="totalCost"></param>
        /// <returns></returns>
        public string InsertInvoice(DateTime date, double totalCost)
        {
            return "INSERT INTO Invoices(InvoiceDate, TotalCost) VALUES('#" + date.ToString() + "#', " + totalCost + ")";
        }
        #endregion

        #region Select Queries
        /// <summary>
        /// Returns a query that selects an invoice by invoice number
        /// </summary>
        /// <param name="invoiceNumber"></param>
        /// <returns></returns>
        public string SelectInvoice(int invoiceNumber)
        {
            return "SELECT InvoiceNum, InvoiceDate, TotalCost FROM Invoices WHERE InvoiceNum = " + invoiceNumber;
        }

        /// <summary>
        /// Returns a query that selects all items from the ItemDesc table
        /// </summary>
        /// <returns></returns>
        public string SelectItems()
        {
            return "SELECT * FROM ItemDesc";
        }

        /// <summary>
        /// Returns a query that selects line items by invoice number
        /// </summary>
        /// <param name="invoiceNumber"></param>
        /// <returns></returns>
        public string SelectLineItems(int invoiceNumber)
        {
            return "LineItems.ItemCode, ItemDesc.ItemDesc, ItemDesc.Cost FROM LineItems, ItemDesc Where LineItems.ItemCode = ItemDesc.ItemCode And LineItems.InvoiceNum = " + invoiceNumber;
        }
        #endregion

        #region Update Queries
        /// <summary>
        /// Returns a query that will update the cost of an invoice given the invoice number
        /// </summary>
        /// <param name="totalCost"></param>
        /// <param name="invoiceNumber"></param>
        /// <returns></returns>
        public string UpdateInvoice(int totalCost, int invoiceNumber)
        {
            return "UPDATE Invoices SET TotalCost = " + totalCost + " WHERE InvoiceNum = " + invoiceNumber;
        }
        #endregion

        #region Delete Queries
        /// <summary>
        /// Returns a query that deletes a line item from the LineItems table
        /// </summary>
        /// <param name="invoiceNumber"></param>
        /// <returns></returns>
        public string DeleteLineItems(int invoiceNumber)
        {
            return "DELETE From LineItems WHERE InvoiceNum = " + invoiceNumber;
        }

        /// <summary>
        /// Returns a query that deletes an invoice from the Invoices table
        /// </summary>
        /// <param name="invoiceNumber"></param>
        /// <returns></returns>
        public string DeleteInvoices(int invoiceNumber)
        {
            return "DELETE From Invoices WHERE InvoiceNum = " + invoiceNumber;
        }
        #endregion
    }
}
