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
using static CoffeeHouse.ClassHelper.EFClass;


namespace CoffeeHouse.Windows
{
    /// <summary>
    /// Логика взаимодействия для StaffList.xaml
    /// </summary>
    public partial class StaffList : Window
    {
        public StaffList()
        {
            InitializeComponent();
            dgEmployee.ItemsSource = context.Staff.ToList().Where(i => i.IdStaff % 2 == 0);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
