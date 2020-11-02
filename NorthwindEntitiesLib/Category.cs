using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        // Related entities
        public ICollection<Product> Products { get; set; }
    }
}
