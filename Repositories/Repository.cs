using Kitchen_Mini_Project.IRepositories;
using Kitchen_Mini_Project.Moduls;
using Kitchen_Mini_Project.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }


        public User SignUpUser()
        {
            throw new NotImplementedException();
        }
    }
}
