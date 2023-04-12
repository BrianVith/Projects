using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApiProject.Models
{
    public class SurfSpot
    {
        public int Id { get; set; }
        public string SpotName { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string ImagePath { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
    }
}