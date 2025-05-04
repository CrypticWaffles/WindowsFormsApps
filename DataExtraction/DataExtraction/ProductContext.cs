using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtraction
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name=DataExtraction.Properties.Settings.ProductDatabaseConnectionString") { }

        public DbSet<Product> Products { get; set; }
    }
}
