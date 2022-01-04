using Kitchen_Mini_Project.IRepositories;
using Kitchen_Mini_Project.Moduls;
using Kitchen_Mini_Project.Registration;
using Kitchen_Mini_Project.Repositories;
using System;
using static System.Console;

namespace Kitchen_Mini_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    WriteLine("Registration:\n" +
                              "| 1. SignIn | 2. SignUp |\n" +
                              "input file: [1 or 2]");

                    int choose = int.Parse(ReadLine());
                    if (choose == 1)
                    {
                        SignIn signIn = new SignIn();
                        signIn.SignInUser();
                        break;
                    }
                    else if (choose == 2)
                    {
                        
                        IRepository  repository = new Repository();
                        User user = SignUp.SignUpUser();
                        repository.Create(user);
                        break;
                        
                    }
                    else
                    {
                        Clear();
                        WriteLine("Bunday foydalanuvchi mavjud emas");
                        
                        break;
                    }
                }
                catch
                {
                    Clear();
                    continue;
                }
            }
         
        }
    }
}
