using Kitchen_Mini_Project.IRepositories;
using Kitchen_Mini_Project.Moduls;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Mini_Project.Enums;

namespace Kitchen_Mini_Project.Registration
{
    public class SignUp
    {
        public static User SignUpUser()
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
