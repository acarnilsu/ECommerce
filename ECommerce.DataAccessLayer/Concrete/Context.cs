using ECommerce.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
