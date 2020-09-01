using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Pid { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int? Price { get; set; }
        public string Details { get; set; }
        public int? Cid { get; set; }

        public virtual Categories C { get; set; }
        [JsonIgnore]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
