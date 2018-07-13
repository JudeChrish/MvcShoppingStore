using OnlineShoppingStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingStore.Domain.Entities;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDBContext eFDBCNT = new EFDBContext();
        public IEnumerable<Product> Products
        {            
            get
            {
                return eFDBCNT.Product;
            }
        }
    }
}
