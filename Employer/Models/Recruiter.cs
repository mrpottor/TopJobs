using System.ComponentModel.DataAnnotations;

namespace Employer.Models
{
    public class Recruiter
    {
        [Key]
        public int EmployerId { get; set; }
        [Required]
        public string EmployerName { get; set; }
        [Required]
        public string OganizatonName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
