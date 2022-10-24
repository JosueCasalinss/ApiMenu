using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiMenu.Core.entities
{
    public partial class Delivery
    {
        public int Id { get; set; }
        public double Distance { get; set; }
        public double DeliveryPrice { get; set; }
        public string Details { get; set; }
        public bool Status { get; set; }
        public int IdClient { get; set; }
        public int IdOrderDish { get; set; }
        public int IdEmployee { get; set; }
        public int IdInvoice { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Invoice IdInvoiceNavigation { get; set; }
        public virtual OrderDish IdOrderDishNavigation { get; set; }
    }
}
