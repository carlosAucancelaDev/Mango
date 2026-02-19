using System.ComponentModel.DataAnnotations;

namespace Mango.Web.Models.Dto
{
    public class RegistrationRequestDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
