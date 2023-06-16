using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Model
{
    public class APIUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
