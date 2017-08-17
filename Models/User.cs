using System;
using System.Collections.Generic;
using dojostore.Models;
namespace dojostore
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public List<Order> orders { get; set; }
 
        public User()
        {
            orders = new List<Order>();
        
        }
    }
}
    