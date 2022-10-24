using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiMenu.Core.entities
{
    public partial class City
    {
        public City()
        {
            Client = new HashSet<Client>();
            Employee = new HashSet<Employee>();
            Location = new HashSet<Location>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdState { get; set; }

        public virtual State IdStateNavigation { get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Location> Location { get; set; }
    }
}
