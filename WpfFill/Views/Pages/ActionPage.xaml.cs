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
using WpfFill.Model;

namespace WpfFill.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ActionPage.xaml
    /// </summary>
    public partial class ActionPage : Page
    {
        public Material Material { get; set; }
        public List<IDMaterial> IDMaterials { get; set; }
        public ActionPage (Material material)
        {
            InitializeComponent();
            Material = material;
            IDMaterials = AppData.db.IDMaterial.ToList();
            this.DataContext = this;
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            if( Material.ID ==0)
            {
                AppData.db.Material.Add(Material);
            }
            AppData.db.SaveChanges();
            MessageBox.Show("Данные сохранены", "Успешно",MessageBoxButton.OK,MessageBoxImage.Information);
            NavigationService.GoBack();
        }
    }
}
