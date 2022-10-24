using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiMenu.Core.entities
{
    public partial class Order
    {
        public Order()
        {
            OrderDish = new HashSet<OrderDish>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public string Details { get; set; }
        public int IdLocation { get; set; }
        public int IdEmployee { get; set; }
        public int IdTable { get; set; }
        public int IdOrderStatus { get; set; }

        public virtual Location IdLocationNavigation { get; set; }
        public virtual OrderStatus IdOrderStatusNavigation { get; set; }
        public virtual Table IdTableNavigation { get; set; }
        public virtual ICollection<OrderDish> OrderDish { get; set; }
    }
}
