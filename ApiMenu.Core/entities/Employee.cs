using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiMenu.Core.entities
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastname { get; set; }
        public string SecondLastname { get; set; }
        public int Document { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public bool Status { get; set; }
        public int IdRole { get; set; }
        public int IdGender { get; set; }
        public int IdDocumenttype { get; set; }
        public int IdCity { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual Gender IdGenderNavigation { get; set; }
        public virtual Role IdRoleNavigation { get; set; }
    }
}
