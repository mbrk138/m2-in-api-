using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2_in_api_2.Model
{
    public class Item
    {
        public int ID { get; set; }

        public string image { get; set; }
        public string Description { get; set; }
        public Product product { get; set; }
        public int quantityinstock { get; set; }




    }
}
