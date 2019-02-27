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

namespace KvalitetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonFindCustomerID_Click(object sender, RoutedEventArgs e)
        {
            WindowFindCustomer wfc = new WindowFindCustomer();
            wfc.Show();
            Close();
        }

        private void ButtonRegisterNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            WindowCreateNewCustomer wcnc = new WindowCreateNewCustomer();
            wcnc.Show();
            Close();
        }

        private void ButtonGetOrder_Click(object sender, RoutedEventArgs e)
        {
            WindowGetOrder wgo = new WindowGetOrder();
            wgo.Show();
            Close();
        }
    }
}
