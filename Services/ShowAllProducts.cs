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
    public class ShowAllProducts
    {
        #region Show All Products
        public static void ShowProducts()
        { 
            string json = File.ReadAllText(PathConst.ProductDBPath);

            List<Restaurant> products = JsonConvert.DeserializeObject<List<Restaurant>>(json);
            
            foreach (var product in products)
            {

                foreach ( var foods in product.FoodItems)
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("| {0,58} | {1, 14} | {2, 58} |\n", "FoodName", "FoodType", "CorrectedTerm");

                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("| {0,58} | {1, 14} | {2, 58} |\n\n", foods.foodName, foods.foodType, foods.correctedTerm);

                    WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");

                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n",
                        "Calories", "SideItem", "DressingItem", "Protein", "KetchupItem", "BreakfastItem", "Carbs", "Sodium");

                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n\n"
                        , foods.calories, foods.sideItem,
                        foods.dressingItem, foods.protein, foods.ketchupItem,
                        foods.breakfastItem, foods.carbs, foods.sodium);

                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");


                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("-----------------------------------------------------------------NEXT----------------------------------------------------------------------\n\n");


                    ForegroundColor = ConsoleColor.White;
                }
                
            }
        }
        #endregion


        #region Choose Restarant 
        public static void ChooseRestaurant(string restaurantName)
        {
            string json = File.ReadAllText(PathConst.ProductDBPath);

            IList<Products> products = JsonConvert.DeserializeObject<IList<Products>>(json);
            IList<Restaurant> rests = JsonConvert.DeserializeObject<IList<Restaurant>>(json);
            int i = 0;
            foreach (Products product in products)
            {
                if (rests[i].RestaurantName.ToLower().Trim() == restaurantName.ToLower().Trim())
                {
                    for (int j = 0; j < rests[i].FoodItems.Count; j++)
                    {

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");
                        ForegroundColor = ConsoleColor.DarkYellow;
                        WriteLine("| {0,58} | {1, 14} | {2, 58} |\n", "FoodName", "FoodType", "CorrectedTerm"); 

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("| {0,58} | {1, 14} | {2, 58} |\n\n", rests[i].FoodItems[j].foodName, rests[i].FoodItems[j].foodType, rests[i].FoodItems[j].correctedTerm);

                        WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");

                        ForegroundColor = ConsoleColor.DarkYellow;
                        WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n", 
                            "Calories", "SideItem","DressingItem", "Protein", "KetchupItem", "BreakfastItem", "Carbs", "Sodium");

                        ForegroundColor= ConsoleColor.Green;
                        WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n\n" 
                            , rests[i].FoodItems[j].calories, rests[i].FoodItems[j].sideItem,
                            rests[i].FoodItems[j].dressingItem, rests[i].FoodItems[j].protein, rests[i].FoodItems[j].ketchupItem, 
                            rests[i].FoodItems[j].breakfastItem, rests[i].FoodItems[j].carbs, rests[i].FoodItems[j].sodium);

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");


                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("-----------------------------------------------------------------NEXT----------------------------------------------------------------------\n\n");


                        ForegroundColor = ConsoleColor.White;
                    }

                }
                i++;

                
            }

        }

        #endregion


    }
}
