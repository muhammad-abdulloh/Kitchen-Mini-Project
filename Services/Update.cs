using Kitchen_Mini_Project.Constants;
using Kitchen_Mini_Project.Moduls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Mini_Project.Services
{
    public class Update
    {
        public static void UpdateAnyProduct()
        {
            string readdedFile = File.ReadAllText(PathConst.ProductDBPath);

            IList<Restaurant> products = JsonConvert.DeserializeObject<IList<Restaurant>>(readdedFile);

            foreach (var product in products[0].FoodItems)
            {
                if (product.foodName == "Chicken Burrito")
                {
                    product.foodName = "Chicken Burrito is Update ha ha";
                }
            }

            var json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(PathConst.ProductDBPath, json);
        }
    }
}
