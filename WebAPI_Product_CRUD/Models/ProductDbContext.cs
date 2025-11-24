using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace WebAPI_Product_CRUD.Models
{
    public class ProductDbContext :DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
