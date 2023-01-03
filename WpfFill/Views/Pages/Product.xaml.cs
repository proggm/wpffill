using System;
using System.Collections.Generic;
using System.Data;
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
using WpfFill.Context;

namespace WpfFill.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            gridprod.ItemsSource = AppData.db.Product.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void tx4_TextChanged(object sender, TextChangedEventArgs e)
        {
           gridprod.ItemsSource = AppData.db.Product.Where(item => item.ID.ToString().Contains(tx4.Text) || item.Article.ToString().Contains(tx4.Text)).ToList();
        }
    }
    
}
