using System;
using System.Collections.Generic;
using dojostore.Models;
namespace dojostore
{
     public class Product : BaseEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Inventory { get; set; }
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt { get; set; }
        public List<Order> orders { get; set; }
 
        public Product()
        {
            orders = new List<Order>();
        
        }

    }
}