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
using Prak4.Classes;
using Newtonsoft.Json;
using System.IO;

namespace Prak4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> Products { get; set; }
        public List<string> Producers { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("..\\..\\Toys.json"));

            Producers = new List<string>();
            foreach (var prod in Products)
            {
                if (!Producers.Contains(prod.Producer))
                    Producers.Add(prod.Producer);
            }
            Producers.Add("Все");

            DataContext = this;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var result = new List<Product>(Products);
            if (cbProducer.SelectedItem as string != "Все")
                result = result.Where(x => x.Producer == cbProducer.SelectedItem as string).ToList();
            if (serchBox.Text != "")
                result = result.Where(x => x.Name.ToLower().Contains(serchBox.Text.ToLower()) || x.Description.ToLower().Contains(serchBox.Text.ToLower())).ToList();

            phonesGrid.ItemsSource = result;
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            (new BuyWindow(Products.Where(x=>x.IsActive && x.Count > 0 ).ToList())).ShowDialog();
        }

        private void SortPricesClick(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content == "\ue5cf")
            {
                (sender as Button).Content = "\ue5ce";
                phonesGrid.ItemsSource = (phonesGrid.ItemsSource as List<Product>).OrderBy(x=>x.Price).ToList();
            }
            else 
            {
                (sender as Button).Content = "\ue5cf";
                var temp = (phonesGrid.ItemsSource as List<Product>).OrderBy(x => x.Price).ToList();
                temp.Reverse();
                phonesGrid.ItemsSource = temp;
            }
        }

        private void serchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var result = new List<Product>(Products);
            if (cbProducer.SelectedItem as string != "Все")
                result = result.Where(x => x.Producer == cbProducer.SelectedItem as string).ToList();
            if (serchBox.Text != "")
                result = result.Where(x => x.Name.Contains(serchBox.Text) || x.Description.Contains(serchBox.Text)).ToList();

            phonesGrid.ItemsSource = result;
        }
    }
}
