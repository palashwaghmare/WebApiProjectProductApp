using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApiProject.AppDbContext
{
    public class APIUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        [Key]
        public int UserId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        


    }
}
