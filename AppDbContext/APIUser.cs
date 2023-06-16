using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApiProject.AppDbContext
{
    public class APIUser : IdentityUser
    {
        

      

        public string FirstName { get; set; }
        public string LastName { get; set; }






    }
}
