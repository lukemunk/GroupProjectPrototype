using System;

namespace GroupProject.Classes
{
    class Invoice
    {
        #region Attributes
        /// <summary>
        /// Holds the unique invoice number for each invoice
        /// </summary>
        public int InvoiceNum { get; set; }
        /// <summary>
        /// Holds the date for the invoice
        /// </summary>
        public DateTime InvoiceDate { get; set; }
        /// <summary>
        /// Holds the total cost of items for the invoice
        /// </summary>
        public double TotalCost { get; set; }
        #endregion
    }
}
