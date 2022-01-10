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
    public class Update
    {
        public static void UpdateAnyProduct()
        {
            string readdedFile = File.ReadAllText(PathConst.ProductDBPath);

            IList<Restaurant> products = JsonConvert.DeserializeObject<IList<Restaurant>>(readdedFile);


            WriteLine("Entering old Food: ");
            string oldFood = ReadLine();

            WriteLine("Entering new Food: ");
            string  newFood = ReadLine();
            foreach (var product in products)
            {
               foreach (var item in product.FoodItems)
                {
                    if (item.foodName == oldFood)
                    {
                        item.foodName = newFood;
                    }                    
                }
            }

            var json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(PathConst.ProductDBPath, json);
        }
    }
}
