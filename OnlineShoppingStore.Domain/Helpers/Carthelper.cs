using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Helpers
{
    public  class Carthelper
    {
        public Cart GetCart(Cart SessionOfCart)
        {
            Cart cart = SessionOfCart;
            if(cart == null)
            {
                cart = new Cart();               
            }
            return cart;
        }
    }
}
