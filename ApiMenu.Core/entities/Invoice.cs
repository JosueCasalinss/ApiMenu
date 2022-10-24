using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiMenu.Core.entities
{
    public partial class Invoice
    {
        public Invoice()
        {
            Delivery = new HashSet<Delivery>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int IdOrderDish { get; set; }
        public int Taxes { get; set; }
        public int Tip { get; set; }
        public int TotalInvoice { get; set; }

        public virtual OrderDish IdOrderDishNavigation { get; set; }
        public virtual ICollection<Delivery> Delivery { get; set; }
    }
}
