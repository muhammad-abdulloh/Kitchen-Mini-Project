﻿using Kitchen_Mini_Project.IRepositories;
using Kitchen_Mini_Project.Moduls;
using Kitchen_Mini_Project.Registration;
using Kitchen_Mini_Project.Repositories;
using Kitchen_Mini_Project.Services;
using System;
using static System.Console;

namespace Kitchen_Mini_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new Repository();
            while (true)
            {
                try
                {
                    WriteLine("Registration:\n" +
                              "| 1. SignIn | 2. SignUp |\n" +
                              "input file: [1 or 2]");

                    int choose = int.Parse(ReadLine().Trim());
                    if (choose == 1)
                    {

                        WriteLine("Input Login: ");
                        string login = ReadLine();

                        WriteLine("Input Password");
                        ForegroundColor = ConsoleColor.Black;
                        string password = ReadLine();
                        ForegroundColor = ConsoleColor.White;

                        repo.SignInUser(login, password);

                        UserMenu.Menu();


                        //UserInfo userInfo = new UserInfo(login, password);

                        //userInfo.ShowUserInfo();
                        break;
                    }
                    else if (choose == 2)
                    {

                        IRepository repository = new Repository();
                        User user = repo.SignUpUser();
                        repository.Create(user);
                        Clear();

                        ForegroundColor = ConsoleColor.Blue;
                        WriteLine("Muvoffaqiyatli yakunlandi :)");
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
