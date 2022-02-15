using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContosoCrafts.Website.Models
{
    public class Product
    {
        //ctrl + F5 to run w/o debugging
        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]//mapped over to the json file
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);     //taking all the object info and converting it to the text 
        //that will be part of the json and make a nice string

    }
}
