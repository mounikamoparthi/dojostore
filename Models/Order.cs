using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using dojostore.Models;
 
namespace dojostore.Models
{
    public class Order : BaseEntity
    {
        public int OrderId {get; set;}
        public int UserId {get; set;}
        public User users {get;set;}
        public int ProductId {get; set;}
        public Product products {get; set;}
        [Required]
        public int Quantity {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get; set;}
    }
}