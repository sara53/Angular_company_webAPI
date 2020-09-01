using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Users
    {
        public Users()
        {
            Orders = new HashSet<Orders>();
        }

        public int UserId { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
