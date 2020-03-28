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
using System.Windows.Shapes;

namespace GroupProject.Search
{
    /// <summary>
    /// Interaction logic for wndSearch.xaml
    /// </summary>
    public partial class wndSearch : Window
    {
        public wndSearch()
        {
            InitializeComponent();
        }

        private void ClearSelectionBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

        private void SelectInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch
            {

            }
        }

        private void AddInvoicesBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch
            {

            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                this.Hide();
                e.Cancel = true;
            }
            catch
            {

            }
        }

        private void InvoiceCbo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

        private void TotalCostCbo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
