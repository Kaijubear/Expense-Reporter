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

namespace ExpenseReporter
{
    /// <summary>
    /// Interaction logic for ExpenseReporterHome.xaml
    /// </summary>
    public partial class ExpenseReporterHome : Page
    {
        public ExpenseReporterHome()
        {
            InitializeComponent();
        }
        private void Button_Click(object Sender, RoutedEventArgs e)
        {
            //View Expense reports
            ExpenseReportPage erp = new ExpenseReportPage();
            this.NavigationService.Navigate(erp);
        }
    }
}
