using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Abstract
{
    public interface IProductRepository
    {
        /// <summary>
        /// sets the values to Products Interface
        /// </summary>
      IEnumerable<Product> Products { get; }
    }
}
