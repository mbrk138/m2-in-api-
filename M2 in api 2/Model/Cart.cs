using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2_in_api_2.Model
{
    public class Cart
    {
        public Cart()
        {
            cartItems = new List<CartItem>();
        }
        public int ID { get; set; }

        List<CartItem> cartItems { get; set; }

        public void AddItem(CartItem item)
        {
            if (cartItems.Exists(x => x.item.ID == item.item.ID))
            {
                cartItems.Find(f => f.item.ID == item.item.ID)
                    .Quantity += 1;

            }
            else
            {
                cartItems.Add(item);


            }
        }

        public void RemoveItem(int items)
        {
            var item = cartItems.SingleOrDefault(s => s.item.ID == items);
            if (item.Quantity <= 1)
            {
                cartItems.Remove(item);

            }
            else if (item != null)
            {
                item.Quantity -= 1;

            }


        }





    }
}
