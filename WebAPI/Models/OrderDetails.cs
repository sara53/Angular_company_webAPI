using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class OrderDetails
    {
        public int Pid { get; set; }
        public int Oid { get; set; }
        public int? Quantity { get; set; }

        public virtual Orders O { get; set; }
        public virtual Products P { get; set; }
    }
}
