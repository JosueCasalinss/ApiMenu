using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiMenu.Core.entities
{
    public partial class Dish
    {
        public Dish()
        {
            OrderDish = new HashSet<OrderDish>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public string Details { get; set; }

        public virtual ICollection<OrderDish> OrderDish { get; set; }
    }
}
