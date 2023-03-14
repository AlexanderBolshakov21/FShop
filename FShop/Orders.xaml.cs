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
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        public Orders()
        {
            InitializeComponent();
            DbShopContext db = new DbShopContext();
            List<Order> order = db.Orders.ToList();
            DGridOrder.ItemsSource = DbShopContext.GetContext().Orders.ToList();
        }

        private void DGridOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminCatalog ac = new AdminCatalog();
            this.Close();
            ac.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var productsForRemoving = DGridOrder.SelectedItems.Cast<Order>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {productsForRemoving.Count()} элемента(ов)?", "Внимание",
             MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                try
                {
                    DbShopContext.GetContext().Orders.RemoveRange(productsForRemoving);
                    DbShopContext.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    DGridOrder.ItemsSource = DbShopContext.GetContext().Orders.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
        }
    }
}
