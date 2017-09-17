using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCRUDApplicationMVC.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}