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
    /// Логика взаимодействия для PersAcc.xaml
    /// </summary>
    public partial class PersAcc : Window
    {
        public PersAcc()
        {
            InitializeComponent();
            using (DbShopContext context = new DbShopContext())
            {
                foreach (User authUser in context.Users)
                {
                    if (authUser.Id == MainWindow.DUser)
                    {
                        loginlab.Content = authUser.Login.ToString();
                        fullnamelab.Content = authUser.Fullname.ToString();
                        phonelab.Content = authUser.Phone.ToString();
                    }
                }
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeButton.Visibility = Visibility.Hidden;
            loginlab.Visibility = Visibility.Hidden;
            fullnamelab.Visibility = Visibility.Hidden;
            phonelab.Visibility = Visibility.Hidden;
            logtb.Visibility = Visibility.Visible;
            fulltb.Visibility = Visibility.Visible;
            phtb.Visibility = Visibility.Visible;
            SaveButton.Visibility = Visibility.Visible;
            using (DbShopContext context = new DbShopContext())
            {
                foreach (User authUser in context.Users)
                {
                    if (authUser.Id == MainWindow.DUser)
                    {
                        logtb.Text = authUser.Login.ToString();
                        fulltb.Text = authUser.Fullname.ToString();
                        phtb.Text = authUser.Phone.ToString();
                    }
                }
            }

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (DbShopContext db = new DbShopContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Login == logtb.Text);
                if (user != null)
                {
                    MessageBox.Show("Такой логин уже существует!");
                }
                foreach (User authUser in db.Users)
                {
                    if (authUser.Id == MainWindow.DUser)
                    {
                        authUser.Login = logtb.Text;
                        authUser.Fullname = fulltb.Text;
                        authUser.Phone = phtb.Text;
                        db.SaveChanges();
                        MessageBox.Show("Информация сохранена!");
                        this.Close();
                        PersAcc users = new PersAcc();
                        users.Show();

                    }

                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Catalog catalog = new Catalog();
            this.Close();
            catalog.Show(); 
        }

        private void DGridUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }
    }
}
