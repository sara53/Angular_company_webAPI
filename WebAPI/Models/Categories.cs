using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int Cid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
