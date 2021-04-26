using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR1925.Entities;

namespace PR1925.Classes
{
    class RegistrationWindowClass
    {
        
        public static void CreateUser(RegWindow regWindow)
        {
            var user = new User();
            AuthorizationEntities.GetEntities().Users.Add(user);
            AuthorizationEntities.GetEntities().SaveChanges();
        }
        public static void ShowRegistrationWindow(AutoWindow autoWindow)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
            autoWindow.Close();
        }
    }
}
