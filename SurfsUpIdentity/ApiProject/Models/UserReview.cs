using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProject.Models
{
    public class UserReview
    {
        public int UserReviewId { get; set; }
        public int NumberOfStars { get; set; }
        public string Comments { get; set; }
        public string UserIdReceiver { get; set; }
        public string UserIdRecipient { get; set; }
        
        [ForeignKey("UserIdReceiver")] 
        public virtual User Receiver { get; set; }
        [ForeignKey("UserIdRecipient")] 
        public virtual User Recipient { get; set; }
    }
}