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
    /// Логика взаимодействия для NameProduct.xaml
    /// </summary>
    public partial class NameProduct : Page
    {
        public NameProduct()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            gridnameprod.ItemsSource = AppData.db.IDNameProduct.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void tx3_TextChanged(object sender, TextChangedEventArgs e)
        {
           gridnameprod.ItemsSource = AppData.db.IDNameProduct.Where(item => item.ID.ToString().Contains(tx3.Text));
        }
    }
}

