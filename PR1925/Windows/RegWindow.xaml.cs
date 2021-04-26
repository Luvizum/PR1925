using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PR1925.Classes;
using PR1925.Entities;

namespace PR1925
{
    public partial class RegWindow : Window
    {
        AuthorizationEntities authorizationEntities;
        public RegWindow(AuthorizationEntities authorizationEntities, User user)
        {
            InitializeComponent();
            this.authorizationEntities = authorizationEntities;
            this.DataContext = user;
        }
        public RegWindow()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text == "" || passwordTextBox.Password == "" || emailTextBox.Text == "")
                MessageBox.Show(CheckData());
            else
            {
                RegistrationWindowClass.CreateUser(this);
                MessageBox.Show("Успешно сохранено!");
            }
        }
        public string CheckData()
        {
            char[] ass = new char[6] { '!', '@', '#', '$', '%', '^' };
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            string password = passwordTextBox.Password;
            bool capital = password.Any(Char.IsUpper);
            bool c = password.Any(Char.IsDigit);
            string result = "";
            for (int i = 0; i < ass.Length; i++)
            {
                if (!password.Contains(ass[i]))
                {
                    result += "Отсутствует хотя бы 1 специальный символ\n";
                    break;
                }
            }
            if (password.Length < 6)
            {
                result += "Пароль меньше 6 символов\n";
            }
            if (capital == false)
            {
                result += "Отсутствует хотя бы 1 прописная буква\n";
            }
            if (c == false)
            {
                result += "Отсутствует хотя бы 1 цифра\n";
            }
            if (loginTextBox.Text != "")
            {
                result += "Отстутствует логин\n";
            }
                string email = emailTextBox.Text;
                if (!Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                {
                    result += "Email не подтвержден\n";
                }
            return result;
        }
            
    }
}
