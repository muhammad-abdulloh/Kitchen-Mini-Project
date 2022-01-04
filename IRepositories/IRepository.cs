using Kitchen_Mini_Project.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Mini_Project.IRepositories
{
    public interface IRepository
    {
        public User Create(User user); 
        public User SignUpUser();
        public User SignInUser(string login, string password);

    }
}
