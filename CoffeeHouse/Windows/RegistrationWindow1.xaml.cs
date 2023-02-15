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

namespace CoffeeHouse.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow1.xaml
    /// </summary>
    public partial class RegistrationWindow1 : Window
    {
        public RegistrationWindow1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbFirst.Text))
            {
                MessageBox.Show("Фамилия не может быть пустой");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbLast.Text))
            {
                MessageBox.Show("Имя не может быть пустым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbPatr.Text))
            {
                MessageBox.Show("Отчество не может быть пустым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbNumber.Text))
            {
                MessageBox.Show("Номер телефона не может быть путсым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbEmail.Text))
            {
                MessageBox.Show("Поле с почтой не может быть пустым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbLog.Text))
            {
                MessageBox.Show("Логин не может быть путсым");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbPass.Password))
            {
                MessageBox.Show("Пароль не может быть путсым");
                return;
            }

            var authUser = context.Authorization.ToList()
            .Where(i => i.Login == TbLog.Text)
            .FirstOrDefault();
            if (authUser != null)
            {

                MessageBox.Show("Логин занят");
                return ;
            }
            DB.Authorization acc = new DB.Authorization();
            acc.LastName = TbLast.Text;
            acc.FirstName = TbFirst.Text;
            acc.Patronymic = TbPatr.Text;
            acc.NumberPhone = TbNumber.Text;
            acc.Email = TbEmail.Text;
            acc.Login = TbLog.Text;
            acc.Password = TbPass.Password;
            context.Authorization.Add(acc);
            context.SaveChanges();
            MessageBox.Show("Ок");

        }
    }
}
