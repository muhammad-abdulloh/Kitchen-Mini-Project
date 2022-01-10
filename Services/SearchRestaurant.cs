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
            string entering = ReadLine();

            string json = File.ReadAllText(PathConst.ProductDBPath);

            List<Products> products = JsonConvert.DeserializeObject<List<Products>>(json);
            List<Restaurant> rests = JsonConvert.DeserializeObject <List<Restaurant>> (json);
            int i = 0;
            foreach (Restaurant res in rests)
            {


                
                if (res.RestaurantName.ToLower().Contains(entering.ToLower()))
                {
                    WriteLine(res.RestaurantName);

                }

                /*|| item.correctedTerm.ToString().ToLower().Contains(entering.ToLower().Trim()) || item.calories.ToString().ToLower().Contains(entering.ToLower().Trim())
                        || item.sideItem.ToString().ToLower().Contains(entering.ToLower().Trim()) || item.dressingItem.ToString().ToLower().Contains(entering.ToLower().Trim())
                        || item.protein.ToString().ToLower().Contains(entering.ToLower().Trim()) || item.ketchupItem.ToString().ToLower().Contains(entering.ToLower().Trim())
                        || item.breakfastItem.ToString().ToLower().Contains(entering.ToLower().Trim()) || item.carbs.ToString().ToLower().Contains(entering.ToLower().Trim())
                        || item.sodium.ToString().ToLower().Contains(entering.ToLower().Trim())
                */

                foreach (var item in res.FoodItems)
                {
                        if (item.foodName.ToString().ToLower().Contains(entering.ToLower().Trim()) || item.foodType.ToString().ToLower().Contains(entering.ToLower().Trim())
                        )
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

                /**
                //IEnumerable<Products> enumerable = rests[i].FoodItems.Where(x => x.ToString().Contains(entering));
                if (rests[i].RestaurantName.ToString().ToLower().Trim().Contains(entering)
                    || rests[i].FoodItems[i].foodName.Contains(entering))
                {
                    //for (int j = 0; j < rests[i].FoodItems.Count; j++)
                    //{

                    //}


                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("| {0,58} | {1, 14} | {2, 58} |\n", "FoodName", "FoodType", "CorrectedTerm");

                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("| {0,58} | {1, 14} | {2, 58} |\n\n", rests[i].FoodItems[i].foodName, rests[i].FoodItems[i].foodType, rests[i].FoodItems[i].correctedTerm);


                    WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");

                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n",
                        "Calories", "SideItem", "DressingItem", "Protein", "KetchupItem", "BreakfastItem", "Carbs", "Sodium");

                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n\n"
                        , rests[i].FoodItems[i].calories, rests[i].FoodItems[i].sideItem,
                        rests[i].FoodItems[i].dressingItem, rests[i].FoodItems[i].protein, rests[i].FoodItems[i].ketchupItem,
                        rests[i].FoodItems[i].breakfastItem, rests[i].FoodItems[i].carbs, rests[i].FoodItems[i].sodium
                        );

                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");



                    ForegroundColor = ConsoleColor.Magenta;
                    WriteLine("-----------------------------------------------------------------NEXT----------------------------------------------------------------------\n\n");



                    ForegroundColor = ConsoleColor.White;




                }
                i++;


                */


            }

        }

    }
}


/** 
 * 
 * 
 * 
 * 
 * 
 * 
 * product.breakfastItem.ToString().ToLower().Trim().Contains(entering) ||
                    product.calories.ToString().ToLower().Trim().Contains(entering) || product.dressingItem.ToString().ToLower().Trim().Contains(entering) ||
                    product.correctedTerm.ToString().ToLower().Trim().Contains(entering) || product.foodName.ToString().ToLower().Trim().Contains(entering) ||
                    product.foodType.ToString().ToLower().Trim().Contains(entering) || product.ketchupItem.ToString().ToLower().Trim().Contains(entering) ||
                    product.protein.ToString().ToLower().Trim().Contains(entering) || product.sideItem.ToString().ToLower().Trim().Contains(entering) ||
                    product.sodium.ToString().ToLower().Trim().Contains(entering)
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");
                        ForegroundColor = ConsoleColor.DarkYellow;
                        WriteLine("| {0,58} | {1, 14} | {2, 58} |\n", "FoodName", "FoodType", "CorrectedTerm");

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("| {0,58} | {1, 14} | {2, 58} |\n\n", rests[i].FoodItems[j].foodName, rests[i].FoodItems[j].foodType, rests[i].FoodItems[j].correctedTerm);


                        WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");

                        ForegroundColor = ConsoleColor.DarkYellow;
                        WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n",
                            "Calories", "SideItem", "DressingItem", "Protein", "KetchupItem", "BreakfastItem", "Carbs", "Sodium");

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("| {0, 10} | {1, 10} | {2, 15} | {3, 10} | {4, 15} | {5, 15} | {6, 8} | {7, 8} |\n\n"
                            , rests[i].FoodItems[j].calories, rests[i].FoodItems[j].sideItem,
                            rests[i].FoodItems[j].dressingItem, rests[i].FoodItems[j].protein, rests[i].FoodItems[j].ketchupItem,
                            rests[i].FoodItems[j].breakfastItem, rests[i].FoodItems[j].carbs, rests[i].FoodItems[j].sodium
                            );

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------\n\n");



                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("-----------------------------------------------------------------NEXT----------------------------------------------------------------------\n\n");



                        ForegroundColor = ConsoleColor.White;
*/