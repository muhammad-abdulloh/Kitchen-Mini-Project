using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Mini_Project.Moduls
{
    public class Restaurant
    {

        [JsonProperty("restaurant")]
        public string RestaurantName { get; set; }


        [JsonProperty("foodItems")]
        public IList<Products> FoodItems { get; set; }
        
    }
}
