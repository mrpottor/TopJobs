using System.ComponentModel.DataAnnotations;

namespace Employer.Models
{
    public class JobSeekerRegistration
    {
        [Key]
        public int JobSeekerID { get; set; }
        [Required]
        public string JobSeekerFirstName { get; set; }
        [Required]
        public string JobSeekerLastName { get; set; }
        [Required]
        public string JobSeekerUserName { get; set; }
        [Required]
        public string JobSeekerPassword { get; set; }
        [Required]
        public string JobSeekerQualification { get; set; }
        [Required]
        public DateTime JobSeeker { get; set; }
       
    }
}
