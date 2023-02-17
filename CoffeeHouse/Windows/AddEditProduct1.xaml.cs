using CoffeeHouse.DB;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using CoffeeHouse.ClassHelper;
using static CoffeeHouse.ClassHelper.EFClass;
using System.IO;

namespace CoffeeHouse.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEditProduct1.xaml
    /// </summary>
    public partial class AddEditProduct1 : Window
    {
       

            private string pathPhoto = null;

            public AddEditProduct1()
            {
                InitializeComponent();

                MBTypeProduct.ItemsSource = context.Category.ToList();
                MBTypeProduct.SelectedIndex = 0;
                MBTypeProduct.DisplayMemberPath = "Title";

            CMBSupplier.ItemsSource = context.Suppliers.ToList();
            CMBSupplier.SelectedIndex = 0;
            CMBSupplier.DisplayMemberPath = "Title";
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Title = TbNameProduct.Text;
            product.IdSuppliers = (CMBSupplier.SelectedItem as Suppliers).IdSuppliers;
            product.Price = Convert.ToDecimal(TbPrice.Text);
            product.IdCategory = (MBTypeProduct.SelectedItem as Category).IdCategory;
            if (pathPhoto != null)
            {
                product.image = Convert.ToString(File.ReadAllBytes(pathPhoto));
            }

            context.Product.Add(product);

            context.SaveChanges();
            MessageBox.Show("OK");
        }

        private void BtnChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImgProduct.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                pathPhoto = openFileDialog.FileName;
            }
        }

    }
}
