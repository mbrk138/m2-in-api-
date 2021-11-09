using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2_in_api_2.Model
{
    public class Product
    {
        public Product()
        {
            categories = new List<Category>();
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string NameMark { get; set; }
        public List<Category> categories { get; set; }



    }
}
