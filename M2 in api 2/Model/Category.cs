using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2_in_api_2.Model
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Product inproducts { get; set; }


    }
}
