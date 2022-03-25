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
using Prak4.Classes;
using Newtonsoft.Json;
using System.IO;

namespace Prak4
{
    /// <summary>
    /// Interaction logic for BuyWindow.xaml
    /// </summary>
    public partial class BuyWindow : Window
    {
        public List<Product> Products { get; set; }
        public List<string> PaymentMethods { get; set; }

        public BuyWindow(List<Product> products)
        {
            Products = products;
            PaymentMethods = new List<string> { "Наличными при получении", "Банковская карта", "Google Pay", "Apple Pay" };
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
