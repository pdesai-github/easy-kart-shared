﻿using Newtonsoft.Json;

namespace EasyKart.Shared.Models
{
    public class Product
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
      
    }
}
