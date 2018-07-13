using OnlineShoppingStore.Domain.Entities;
using System.Collections.Generic;

namespace OnlineShoppingStore.WEBUI.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public string  CurrentCategory { get; set; }
    }
}