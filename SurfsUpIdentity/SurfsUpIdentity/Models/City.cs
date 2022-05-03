namespace SurfsUpIdentity.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int PostalCode { get; set; }
        //public virtual User User { get; set; } //skal m�ske v�re der i EF?
    }
}