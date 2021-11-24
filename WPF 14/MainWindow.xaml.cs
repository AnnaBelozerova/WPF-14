using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> product;
        public MainWindow()
        {
            InitializeComponent();
            product = new ObservableCollection<Product>();
            product.Add(new Product()
            {
                ProductName = "Яблоко",
                ProductPrice = 100,
                ProductImage = "Data/Apple.png",
                ProductTypes = ProductTypes.Еда
            });
            product.Add(new Product()
            {
                ProductName = "Компьюетр",
                ProductPrice = 49999,
                ProductImage = "Data/Computer.png",
                ProductTypes = ProductTypes.Бытовая_техника
            });
            product.Add(new Product()
            {
                ProductName = "Тыква",
                ProductPrice = 67.5,
                ProductImage = "Data/Pumpkin.png",
                ProductTypes = ProductTypes.Еда
            });
            listBox.ItemsSource = product;
        }
    }
}
