using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiMenu.Core.entities
{
    public partial class Table
    {
        public Table()
        {
            Order = new HashSet<Order>();
            Reservation = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PersonCapacity { get; set; }
        public bool Status { get; set; }
        public int IdLocation { get; set; }

        public virtual Location IdLocationNavigation { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
