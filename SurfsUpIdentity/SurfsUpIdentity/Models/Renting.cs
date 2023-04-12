using System;

namespace SurfsUpIdentity.Models
{
    public class Renting
    {

        public int RentingId { get; set; }
        public DateTime Date { get; set; }
        public int EquipmentId { get; set; }
        public string UserId { get; set; }
        public virtual Equipment Equipment { get; set; }
        //public User User { get; set; }
    }
}