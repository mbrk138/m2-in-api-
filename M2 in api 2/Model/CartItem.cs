using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2_in_api_2.Model
{
    public class CartItem
    {
        public int ID { get; set; }
        public Item item { get; set; }
        public int Quantity { get;  set; }
        public decimal GetTotulPrice()
        {

            return item.product.Price = Quantity;
        }
 






    }
}
