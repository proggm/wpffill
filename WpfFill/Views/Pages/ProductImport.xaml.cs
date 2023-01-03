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
    /// Логика взаимодействия для ProductImport.xaml
    /// </summary>
    public partial class ProductImport : Page
    {
        public ProductImport()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            gridimport.ItemsSource = AppData.db.ProductImport.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void tx5_TextChanged(object sender, TextChangedEventArgs e)
        {
            gridimport.ItemsSource = AppData.db.ProductImport.Where(item => item.Article.ToString().Contains(tx5.Text) || item.Number.ToString().Contains(tx5.Text)).ToList();
        }
    }
    
}
