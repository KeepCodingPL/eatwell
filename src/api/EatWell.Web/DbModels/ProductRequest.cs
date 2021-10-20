using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.Models
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public List<string> Ingredients = new List<string>();

        public bool IsVegan { get; set; }
        public bool IsVegeterian { get; set; }
        public bool IsHalal { get; set; }

    }

}
