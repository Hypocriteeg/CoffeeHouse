using CoffeeHouse.ClassHelper;
using CoffeeHouse.Windows;
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
using static CoffeeHouse.ClassHelper.EFClass;
using static CoffeeHouse.ClassHelper.StaffDataContext;

namespace CoffeeHouse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbFI.Text = StaffDataContext.staff.Authorization.FirstName.ToString() + " " + StaffDataContext.staff.Authorization.LastName.ToString() + " \\ " + StaffDataContext.staff.Post.Title.ToString();
        }

        private void PBtn_Click(object sender, RoutedEventArgs e)
        {
            ProductListWindow productListWindow = new ProductListWindow();
            this.Hide();
            productListWindow.ShowDialog();
            this.Show();
        }

        private void PBStaff_Click(object sender, RoutedEventArgs e)
        {
            StaffList staffList = new StaffList();
            this.Hide();
            staffList.ShowDialog();
            this.Show();
        }

        private void PBClient_Click(object sender, RoutedEventArgs e)
        {
            AccountList accountList = new AccountList();
            this.Hide();
            accountList.ShowDialog();
            this.Show();
        }
    }
}
