using System.ComponentModel.DataAnnotations;



namespace MVCMovie.Models
{
    public class Review
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 2, ErrorMessage = "Name must have at least 2 characters")]
        [Required]
        public string Reviewer { get; set; }

        [StringLength(120, MinimumLength = 0, ErrorMessage = "Your review must be less than 120 charecters")]

        [Required]
        public string userReview { get; set; }

        [Required]
        public int movieID { get; set; }

        [Required]
        public string MovieTitle { get; set; }
    }
}