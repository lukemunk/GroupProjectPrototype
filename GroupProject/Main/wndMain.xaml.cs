using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using GroupProject.Search;

namespace GroupProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class wndMain : Window
    {
        private wndSearch searchWindow;
        #region Constructor
        /// <summary>
        /// Constructor for the main window
        /// </summary>
        public wndMain()
        {
            InitializeComponent();
            searchWindow = new wndSearch();
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Event handler for the "Search Invoices" menu item. Opens the search window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchInvoicesBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Hide this current window
                this.Hide();
                // Open the search window
                searchWindow.ShowDialog();
                // ReOpen the main window
                this.Show();

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the "Merchandise" menu item. Opens the items window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MerchandiseBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Hide this current window
                // Open the merchandise window
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Event handler for selection changed event. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemCbo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the "Add Item" button. Adds an item selected by the user to the invoice. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get the item selected by the user in the combo box
                // 
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the "Remove Item" button. Removes an item selected by the user from the invoice. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }    

        /// <summary>
        /// Event handler for the "Add Invoice" button. Adds an invoice to the invoice list. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the "Save Invoice" button. Saves the invoice information. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the "Edit Invoice" button. Allows the user to edit an invoice. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the "Delete Invoice" button. Allows the user to delete an invoice. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the "GotFocus" event on the DateInput textbox. Remvoes the date format text from the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateInput_GotFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                DateInput.Text = null;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the "LostFocus" event on the DateInptu textbox. Adds the date format text back to the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateInput_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                DateInput.Text = "mm/dd/yyyy";
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        #endregion

        #region Error Handler
        /// <summary>
        /// Handles all thrown exceptions.
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                System.IO.File.AppendAllText("Error.txt", Environment.NewLine +
                    sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("Error.txt", Environment.NewLine +
                    "HandleError Exception: " + ex.Message);
            }
        }
        #endregion        
    }
}
