using Kitchen_Mini_Project.Enums;
using Kitchen_Mini_Project.IRepositories;
using Kitchen_Mini_Project.Moduls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Kitchen_Mini_Project.Registration
{
    public class SignIn
    {
        

        public static User SignInUser(string login, string password)
        {
            string[] files = Directory.GetFiles(Constants.PathConst.UserDBPath);

            foreach (string file in files)
            {
                string[] userDetails = File.ReadAllLines(file);

                string userLogin = userDetails[4];
                string userPassword = userDetails[5];

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

        
    }
}
