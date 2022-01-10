﻿using Kitchen_Mini_Project.Constants;
using Kitchen_Mini_Project.Moduls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Kitchen_Mini_Project.Services
{
    public class UserMenu
    {

        // Boshidagi menu
        public static void Menu()
        {
            Clear();

            ForegroundColor = ConsoleColor.Green;
            WriteLine("Menu: ");
            Write("| 1. Do you want to buy meal? | " +
                "| 2. Show the all date | " +
                "3. Show user info |");

            ForegroundColor = ConsoleColor.Red;

            Write("| 4. Update" +
                " | 5. Delete |");

            ForegroundColor = ConsoleColor.DarkYellow;

            Write(" 6. Exit |\n\n");
            ForegroundColor= ConsoleColor.Green;
            Write(">>> ");

            ForegroundColor = ConsoleColor.White;
            int choose = int.Parse(ReadLine().Trim());

            if (choose == 1)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("From which restaurant you want to buy?\n");

                ForegroundColor = ConsoleColor.DarkYellow;

                ShowAllReastaurant();

                ForegroundColor = ConsoleColor.Green;

                string restaurant = ReadLine().Trim().ToLower();

                
                Clear();

                ForegroundColor = ConsoleColor.White;
                ShowAllProducts.ChooseRestaurant(restaurant);


            }
            else if (choose == 3)
            {
                ShowAllProducts.ShowProducts();
            }
            else if (choose == 4)
            {
                WriteLine("Update qilishdan oldin oldingi ma'lumotlarni ko'rib olasizmi yoki yo'qmi [y/n]");

                string chooseUpdate = ReadLine().Trim().ToLower();
                if (chooseUpdate == "y" || chooseUpdate == "yes")
                {
                    ShowAllProducts.ShowProducts();

                    ForegroundColor= ConsoleColor.Yellow;
                    WriteLine("Ma'lumotlarni o'zgartirishingiz mumkin :) \n");
                    Update.UpdateAnyProduct();
                    ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    Update.UpdateAnyProduct();
                }
                
            }
            else if (choose == 5)
            {
                ShowAllProducts.ShowProducts();
            }
            else if (choose == 6)
            {
                Write("Exit");
            }

        }

        // Barcha restaranlar ro'yhati
        public static void ShowAllReastaurant()
        {
            string json = File.ReadAllText(PathConst.ProductDBPath);

            var result = JsonConvert.DeserializeObject<IList<Restaurant>>(json);
            
            foreach ( var rest in result)
            {
                Console.WriteLine(rest.RestaurantName);
            }

        }

    }
}
