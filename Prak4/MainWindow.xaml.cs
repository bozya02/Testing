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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var result = new List<Product>(Products);
            try
            {
                if (cbProducer.SelectedItem as string == "Все")
                    throw new Exception();

                result = result.Where(x => x.Producer == cbProducer.SelectedItem as string).ToList();
            }
            catch { }
            phonesGrid.ItemsSource = result;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var result = new List<Product>(Products);
            if (serchBox.Text != "")
                result = result.Where(x => x.Name.Contains(serchBox.Text) || x.Description.Contains(serchBox.Text)).ToList();

            phonesGrid.ItemsSource = result;
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            (new BuyWindow()).Show();
        }
    }
}
