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

namespace FShop
{
    /// <summary>
    /// Логика взаимодействия для Bag.xaml
    /// </summary>
    public partial class Bag : Window
    {
        public Bag()
        {
            InitializeComponent();
            CatalogList.ItemsSource = DbShopContext.GetContext().Products.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

                PersAcc users = new PersAcc();
                this.Close();
                users.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                Catalog users = new Catalog();
                this.Close();
                users.Show();
        }

        private void Catalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
