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
using Newtonsoft.Json;
using Prak4.DataBase;
using System.IO;

namespace Prak4
{
    /// <summary>
    /// Interaction logic for BuyWindow.xaml
    /// </summary>
    public partial class BuyWindow : Window
    {
        public List<Product> Products { get; set; }
        public List<Payment> PaymentMethods { get; set; }
        public Product Product { get; set; }
        public List<Buyer> Buyers { get; set; }
        public List<DeliveryType> DeliveryTypes { get; set; }

        public BuyWindow(Product product)
        {
            Product = product;
            Products = ToysShopEntities.GetContext().Product.ToList();
            PaymentMethods = ToysShopEntities.GetContext().Payment.ToList();
            Buyers = ToysShopEntities.GetContext().Buyer.ToList();
            DeliveryTypes = ToysShopEntities.GetContext().DeliveryType.ToList();
            InitializeComponent();
            DataContext = this;
        }


        private void cdDelivery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbAddress.Visibility = (cdDelivery.SelectedItem as DeliveryType).Name == "Самовывоз" ? Visibility.Hidden : Visibility.Visible;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            if (!int.TryParse(tbCount.Text, out count))
            {
                MessageBox.Show("Опять дебил?\nВпиши число, ЧУРКА!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Hand);
                return;
            }
            else if (count > Product.Count)
            {
                MessageBox.Show("Опять дебил?\nСлишком много на себя берешь", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Hand);
                return;
            }
            else if (count < 0)
            {
                MessageBox.Show("Ты богатый что-ли?\nНаш ничего от тебя не надо", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Hand);
                return;
            }
            else if (cbBuyer.SelectedItem as Buyer == null)
            {
                MessageBox.Show("Выбери покупателя\nЧел ты, чел ты...", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Hand);
                return;
            }
            else if (cbPaymentMethod.SelectedItem as Payment == null)
            {
                MessageBox.Show("Выбери способ оплаты\nЧел ты, чел ты...", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Hand);
                return;
            }
            else if (cdDelivery.SelectedItem as DeliveryType == null)
            {
                MessageBox.Show("Выбери способ доставки\nЧел ты, чел ты...", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Hand);
                return;
            }

            Order order = new Order
            {
                Address = tbAddress.Text.Length == 0 ? null : tbAddress.Text,
                BuyerId = (cbBuyer.SelectedItem as Buyer).Id,
                Count = count,
                DeliveryTypeId = (cdDelivery.SelectedItem as DeliveryType).Id,
                ProductId = Product.Id,
                PaymentId = (cbPaymentMethod.SelectedItem as Payment).Id
            };

            ToysShopEntities.GetContext().Order.Add(order);
            Product.Count -= count;
            ToysShopEntities.GetContext().SaveChanges();

            this.Close();

        }

        private void cbBuyer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbPhone.Text = (cbBuyer.SelectedItem as Buyer).Phone;
            
        }
    }
}
