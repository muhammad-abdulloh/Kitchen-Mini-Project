using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Mini_Project.Moduls
{
    public class Products
    {
        [JsonProperty("foodName")]
        public string foodName { get; set; }

        [JsonProperty("foodType")]
        public string foodType { get; set; }


        [JsonProperty("correctedTerm")]
        public string correctedTerm { get; set; }


        [JsonProperty("calories")]
        public int? calories { get; set; }


        [JsonProperty("sideItem")]
        public bool? sideItem { get; set; }


        [JsonProperty("dressingItem")]
        public bool? dressingItem { get; set; }


        [JsonProperty("protein")]
        public string protein { get; set; } 


        [JsonProperty("ketchupItem")]
        public bool? ketchupItem { get; set; }


        [JsonProperty("breakfastItem")]
        public bool? breakfastItem { get; set; }


        [JsonProperty("carbs")]
        public int? carbs { get; set; }


        [JsonProperty("sodium")]
        public int? sodium { get; set; }
        
    }
}
