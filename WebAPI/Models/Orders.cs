using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Oid { get; set; }
        public DateTime? Date { get; set; }
        public int? TotalPrice { get; set; }
        public string State { get; set; }
        public int? UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
