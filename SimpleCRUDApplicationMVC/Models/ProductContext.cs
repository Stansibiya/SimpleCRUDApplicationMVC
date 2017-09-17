using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SimpleCRUDApplicationMVC.Models;

namespace SimpleCRUDApplicationMVC.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Products> products { get; set; }
    }
}