using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AdminManipulation.xaml
    /// </summary>
    public partial class AdminManipulation : Window
    {
        private Product _currentProduct = new Product();
        public AdminManipulation(Product selectedProduct)
        {
            InitializeComponent();
            if (selectedProduct != null)
                _currentProduct = selectedProduct;

            DataContext = selectedProduct;

            if (_currentProduct.Image != null)
            {
                ImageR.Source = LoadImage(_currentProduct.Image);
            }
        }
        private string imagepath = "";
        private void ChangePhotoButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openDialog.ShowDialog() == true)
            {
                imagepath = openDialog.FileName;
                ImageR.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }
        public static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ( NameTB.Text == "" || QuTB.Text == "" || PriceTB.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            if (_currentProduct == null)
            {
                _currentProduct = new Product() { Quantity = Convert.ToInt32(QuTB.Text), Description = DescTb.Text, Price = Convert.ToInt32(PriceTB.Text), Name = NameTB.Text };
            }
            else
            {
                _currentProduct.Name = NameTB.Text;
                _currentProduct.Quantity = Convert.ToInt32(QuTB.Text);
                _currentProduct.Description = DescTb.Text;
                _currentProduct.Price = Convert.ToInt32(PriceTB.Text);
            }
            if (imagepath != "")
                _currentProduct.Image = File.ReadAllBytes(imagepath);
            if (_currentProduct.Id == 0)
                DbShopContext.GetContext().Products.Add(_currentProduct);
            try
            {
                DbShopContext.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


            
        
        }
    }
}
