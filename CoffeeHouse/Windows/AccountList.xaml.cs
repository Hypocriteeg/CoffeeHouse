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
using static CoffeeHouse.ClassHelper.EFClass;

namespace CoffeeHouse.Windows
{
    /// <summary>
    /// Логика взаимодействия для AccountList.xaml
    /// </summary>
    public partial class AccountList : Window
    {
        public AccountList()
        {
            InitializeComponent();
            dgAcc.ItemsSource = context.Authorization.ToList();
        }
    }
}
