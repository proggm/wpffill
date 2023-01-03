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
using WpfFill.Context;

namespace WpfFill.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataView.ItemsSource = AppData.db.Material.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TypeMaterial());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Product());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NameProduct());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductImport());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new IDtypePRODUCT());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void tx1_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataView.ItemsSource = AppData.db.Material.Where(item => item.ID.ToString().Contains(tx1.Text) || item.NameMaterial.Contains(tx1.Text)).ToList();
        }
    }
}
