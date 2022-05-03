using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication;

namespace SurfsUpIdentity.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; } = false;
        public bool IsPremium { get; set; } = false;
        public int CityId { get; set; }
        public virtual City City { get; set; }

        //public virtual ICollection<Renting> Rentings { get; set; }
        //public virtual ICollection<Equipment> Equipments { get; set; }
    }
}