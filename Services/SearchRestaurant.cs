using Kitchen_Mini_Project.Constants;
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
    public class SearchRestaurant
    {

        public static void SearchAll()
        {
            WriteLine("Write anything: ");
            Write(">>> ");
            string entering = ReadLine();

            string json = File.ReadAllText(PathConst.ProductDBPath);

            List<Products> products = JsonConvert.DeserializeObject<List<Products>>(json);
            List<Restaurant> rests = JsonConvert.DeserializeObject <List<Restaurant>> (json);
            
            foreach (Restaurant res in rests)
            {
                if (res.RestaurantName.ToLower().Contains(entering.ToLower().Trim()))
                {
                    WriteLine(res.RestaurantName);

                }


                foreach (var item in res.FoodItems)
                {

                    if (!string.IsNullOrEmpty(item.foodType))
                    {

                        if (item.foodName.ToString().ToLower().Contains(entering.ToLower().Trim()) || item.foodType.ToString().ToLower().Contains(entering.ToLower().Trim()))
                        {
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");
                        ForegroundColor = ConsoleColor.DarkYellow;
                        WriteLine("| {0,58} | {1, 14} | {2, 58} |\n", "FoodName", "FoodType", "CorrectedTerm");

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("| {0,58} | {1, 14} | {2, 58} |\n\n", item.foodName, item.foodType, item.correctedTerm);


                        WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");

                        ForegroundColor = ConsoleColor.DarkYellow;
                        WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n",
                            "Calories", "SideItem", "DressingItem", "Protein", "KetchupItem", "BreakfastItem", "Carbs", "Sodium");

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n\n"
                            , item.calories, item.sideItem,item.dressingItem, item.protein, item.ketchupItem,
                            item.breakfastItem, item.carbs, item.sodium
                            );

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");

                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("-----------------------------------------------------------------NEXT----------------------------------------------------------------------\n\n");

                        ForegroundColor = ConsoleColor.White;
                        }                  
                    }
                    else
                    {
                        if (item.foodName.ToString().ToLower().Contains(entering.ToLower().Trim()) )
                        {
                            ForegroundColor = ConsoleColor.Green;
                            WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine("| {0,58} | {1, 14} | {2, 58} |\n", "FoodName", "FoodType", "CorrectedTerm");

                            ForegroundColor = ConsoleColor.Green;
                            WriteLine("| {0,58} | {1, 14} | {2, 58} |\n\n", item.foodName, item.foodType, item.correctedTerm);


                            WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");

                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n",
                                "Calories", "SideItem", "DressingItem", "Protein", "KetchupItem", "BreakfastItem", "Carbs", "Sodium");

                            ForegroundColor = ConsoleColor.Green;
                            WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n\n"
                                , item.calories, item.sideItem, item.dressingItem, item.protein, item.ketchupItem,
                                item.breakfastItem, item.carbs, item.sodium);

                            ForegroundColor = ConsoleColor.Green;
                            WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");


                            ForegroundColor = ConsoleColor.Magenta;
                            WriteLine("-----------------------------------------------------------------NEXT----------------------------------------------------------------------\n\n");

                            ForegroundColor = ConsoleColor.White;
                        }
                    }
                }

            }

        }

    }
}

