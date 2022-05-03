namespace SurfsUpIdentity.Models
{
    public class Picture
    {

        public int PictureId { get; set; }
        public string PicturePath { get; set; }
        public int EquipmentId { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}