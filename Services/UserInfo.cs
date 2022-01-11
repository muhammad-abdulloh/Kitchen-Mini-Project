using Kitchen_Mini_Project.Moduls;
using Kitchen_Mini_Project.Registration;
using Kitchen_Mini_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Mini_Project.Services
{
    public class UserInfo
    {
        private readonly string _login;
        private readonly string _password;
        Repository repo = new Repository();

        public UserInfo()
        {
        }

        public UserInfo(string login, string password)
        {
            _login = login;
            _password = password;
        }
        public void ShowUserInfo()
        {
            User user = new User();
            
            user = repo.SignInUser(_login, _password);

            Console.WriteLine("Firstname: " + user.FirstName);
            Console.WriteLine("Lastname: " + user.LastName);
            Console.WriteLine("Id: " + user.Id);
            Console.WriteLine("Login: " + user.Login);
            Console.WriteLine("Password: " + user.Password);
            Console.WriteLine("Role: " + user.Role);

        }
    }
}
