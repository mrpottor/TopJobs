using System.ComponentModel.DataAnnotations;
using JobSeeker.Models;

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
        public QualificationType JobSeekerQualification { get; set; }
        [Required]
        public DateOnly JobSeekerYOP { get; set; }
        [Required]
        public int JobSeekerTotalExp { get; set; }

    }
}
