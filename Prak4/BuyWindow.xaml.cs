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
using System.ComponentModel.DataAnnotations;

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
            cdDelivery.SelectedIndex = 0;
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var order = new Order
                {
                    ProductName = cbProducts.SelectedItem.ToString(),
                    Сount =  int.Parse(tbCount.Text),
                    DeliveryType = cdDelivery.SelectedItem.ToString(),
                    BuyerName = tbName.Text,
                    PaymentMethod = cbPaymentMethods.SelectedItem.ToString(),
                    PhoneNumber = tbPhone.Text
                };
                var messageBoxText = "";
                var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
                var context = new ValidationContext(order);
                if (!Validator.TryValidateObject(order, context, results, true))
                {
                    foreach (var error in results)
                    {
                        messageBoxText += $"{error.ErrorMessage}\n";
                    }
                }
                if (messageBoxText == "")
                    Close();
                else
                    MessageBox.Show(messageBoxText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибки в веденных данных");
            }
        }

        private void cdDelivery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            spAddress.Visibility = cdDelivery.SelectedIndex == 0 ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
