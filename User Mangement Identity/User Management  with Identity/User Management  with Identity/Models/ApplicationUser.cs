using System.ComponentModel.DataAnnotations;

namespace User_Management__with_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        //public byte[] ProfilePicture { get; set; }
    }
}
