using System.ComponentModel.DataAnnotations;

namespace JobApplication.Models
{
    public class Class
    {
        [Key]
        public int JobSeekerId { get; set; }
        [Required]
        public string JobSeekerUserName { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string JobSeekerQualification{ get; set; }
        [Required]
        public DateOnly JobSeekerYOP { get; set; }
        [Required]
        public int JobSeekerTotalExp { get; set; }

    }
}
