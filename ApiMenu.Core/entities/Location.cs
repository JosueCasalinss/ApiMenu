using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiMenu.Core.entities
{
    public partial class Location
    {
        public Location()
        {
            Order = new HashSet<Order>();
            Reservation = new HashSet<Reservation>();
            Table = new HashSet<Table>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Details { get; set; }
        public int IdCity { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
        public virtual ICollection<Table> Table { get; set; }
    }
}
