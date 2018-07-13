using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Entities
{
    public class Cart
    {
        public List<CartLine> LineCollection = new List<CartLine>();
        private CartLine Line;

        public void AddItem(Product Selected_product, int Selected_Quantity)
        {
            Line = LineCollection.FirstOrDefault(f => f.Product == Selected_product);

            if(Line == null)
            {
                LineCollection.Add(new CartLine { Product = Selected_product, Quantity = Selected_Quantity });
            }
            else
            {
                Line.Quantity += Selected_Quantity;
            }
        }

        public void RemoveItem(Product Selected_Product, int Quantity)
        {
            LineCollection.RemoveAll(r => r.Product == Selected_Product);
        }

        public decimal ComputeTotalValue()
        {
            return LineCollection.Sum(p => p.Product.Price * p.Quantity);
        }

        public IEnumerable<CartLine> GetAllItems()
        {
            return LineCollection;
        }

        public void ClearTheCart()
        {
            LineCollection.Clear();
        }
    }
}
