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
using static CoffeeHouse.ClassHelper.StaffDataContext;
using System.IO;

namespace CoffeeHouse.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProductListWindow.xaml
    /// </summary>
    public partial class ProductListWindow : Window
    {
        public ProductListWindow()
        {
            InitializeComponent();
            GetProduct();
            if (StaffDataContext.staff.Post.IdPost != 1)
            {
                btnAdd.Visibility = Visibility.Hidden;
            }

        }
        private void GetProduct()
        {
            List<Product> ProdList = new List<Product>();

            ProdList = context.Product.ToList();

            LvProductList.ItemsSource = ProdList;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditProduct1 addEditProduct1 = new AddEditProduct1();
            addEditProduct1.ShowDialog();
        }
    }
}
