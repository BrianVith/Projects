using System;

namespace ApiProject.Models
{
    public class SpotReview
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Rating { get; set; }
        public DateTime Date { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
        public int SpotId { get; set; }
        public virtual SurfSpot SurfSpot { get; set; }
    }
}