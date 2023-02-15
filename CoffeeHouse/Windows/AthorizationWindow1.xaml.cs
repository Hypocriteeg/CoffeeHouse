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
using CoffeeHouse.ClassHelper;
using static CoffeeHouse.ClassHelper.EFClass;

namespace CoffeeHouse.Windows
{
    /// <summary>
    /// Логика взаимодействия для AthorizationWindow1.xaml
    /// </summary>
    public partial class AthorizationWindow1 : Window
    {
        public AthorizationWindow1()
        {
            InitializeComponent();
        }

        private void TbRegist_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RegistrationWindow1 registrationWindow1 = new RegistrationWindow1();
            registrationWindow1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var authUser = context.Authorization.ToList()
            .Where(i => i.Login==LoginBox1.Text && i.Password== PassBx1.Password)
            .FirstOrDefault();
            if (authUser != null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Нет такого пользователя");
            }
        }
    }
}
