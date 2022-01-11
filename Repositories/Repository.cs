using Kitchen_Mini_Project.Enums;
using Kitchen_Mini_Project.IRepositories;
using Kitchen_Mini_Project.Moduls;
using Kitchen_Mini_Project.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Kitchen_Mini_Project.Repositories
{
    public class Repository : IRepository
    {
        public User Create(User user)
        {
            string fileName = MethodService.GetUserPath(user.Id);
            string userDate = user.ToString();

            File.WriteAllTextAsync(fileName, userDate);
            return user;
        }

        public User SignInUser(string login, string password)
        {
            string[] files = Directory.GetFiles(Constants.PathConst.UserDBPath);

            foreach (string file in files)
            {
                string[] userDetails = File.ReadAllLines(file);

                string userLogin = userDetails[4];
                string userPassword = userDetails[5];

                string role = UserRole.Admin.ToString();

                if (login == userLogin && password == userPassword)
                {
                    return new User
                    {
                        Id = Guid.Parse(userDetails[0]),
                        FirstName = userDetails[1],
                        LastName = userDetails[2],
                        Role = (UserRole)Enum.Parse(typeof(UserRole), userDetails[3]),
                        Login = userDetails[4],
                        Password = userDetails[5]

                    };
                }
            }
            return null;
        }

        public User SignUpUser()
        {
            while (true)
            {
                try
                {
                    var user = new User();

                    WriteLine("Input FirstName: ");
                    user.FirstName = ReadLine();

                    WriteLine("Input LastName: ");
                    user.LastName = ReadLine();

                    WriteLine("Input Login: ");
                    user.Login = ReadLine();

                    WriteLine("Input Password: ");
                    user.Password = ReadLine();

                    return user;
                }
                catch
                {
                    WriteLine("Qandaydur hatolik ketdi boshqatdan kiriting: ");
                    continue;
                }
            }
        }
    }
}
