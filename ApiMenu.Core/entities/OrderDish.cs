using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiMenu.Core.entities
{
    public partial class OrderDish
    {
        public OrderDish()
        {
            Delivery = new HashSet<Delivery>();
            Invoice = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdDish { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }

        public virtual Dish IdDishNavigation { get; set; }
        public virtual Order IdOrderNavigation { get; set; }
        public virtual ICollection<Delivery> Delivery { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
