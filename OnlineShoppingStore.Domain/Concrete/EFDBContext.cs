using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    class EFDBContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}
