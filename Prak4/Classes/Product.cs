using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Prak4.Classes
{
    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("producer")]
        public string Producer { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("active")]
        public string Active { get; set; }
        public bool IsActive { get { return Active != "0"; }  }
        [JsonProperty("count")]
        public int Count { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
