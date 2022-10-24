using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiMenu.Core.entities
    public partial class Reservation
    {
        public int Id { get; set; }
        public string ReservationNumber { get; set; }
        public int PersonNumber { get; set; }
        public DateTime ReservationDate { get; set; }
        public bool Status { get; set; }
        public int IdLocation { get; set; }
        public string Details { get; set; }
        public int IdTable { get; set; }
        public int IdClient { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Location IdLocationNavigation { get; set; }
        public virtual Table IdTableNavigation { get; set; }
    }
}
