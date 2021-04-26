using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PR1925.Entities;

namespace PR1925.Classes
{
    class AuthorizationWindowClass
    {
        public static void CheckData(AutoWindow autoWindow)
        {
            var check = AuthorizationEntities.GetEntities().Users.FirstOrDefault(x => x.Login == autoWindow.loginTextBox.Text 
                                                                                    && x.Password == autoWindow.passwordTextBox.Password);
            if (check == null)
            {
                MessageBox.Show("Неверно введен логин или пароль");
            }
            else
            {
                UsersWindow usersWindow = new UsersWindow(check);
                usersWindow.Show();
                autoWindow.Close();
            }
        }
    }
}
