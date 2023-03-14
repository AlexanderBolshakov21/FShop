using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace FShop
{
    /// <summary>
    /// Логика взаимодействия для AdminCatalog.xaml
    /// </summary>
    public partial class AdminCatalog : Window
    {
        public AdminCatalog()
        {
            InitializeComponent();
            AdminCatalogList.ItemsSource = DbShopContext.GetContext().Products.ToList();
        }

       

        private void AdminCatalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminManipulation adminManipulation = new AdminManipulation((sender as Button).DataContext as Product);
            adminManipulation.ShowDialog();
            AdminCatalogList.ItemsSource = DbShopContext.GetContext().Products.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var productsForRemoving = AdminCatalogList.SelectedItems.Cast<Product>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {productsForRemoving.Count()}элемента(ов)?", "Внимание",
             MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                try
                {
                    DbShopContext.GetContext().Products.RemoveRange(productsForRemoving);
                    DbShopContext.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    AdminCatalogList.ItemsSource = DbShopContext.GetContext().Products.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AdminManipulation adminManipulation = new AdminManipulation(AdminCatalogList.SelectedItem as Product);
            adminManipulation.ShowDialog();
            AdminCatalogList.ItemsSource = DbShopContext.GetContext().Products.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();
            this.Close();
            orders.Show();
        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
