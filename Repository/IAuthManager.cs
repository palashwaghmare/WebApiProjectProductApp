using Microsoft.AspNetCore.Identity;
using WebApiProject.Model;

namespace WebApiProject.Repository
{
    public interface IAuthManager
    {

        Task<IEnumerable<IdentityError>> RegisterUser(APIUserDTO userDto);
        Task<AuthresponseDTO> Login(LogInDTO logindto);

        Task<string> CraeteRefreshToken();
        Task<AuthresponseDTO> VerifyRefreshToken(AuthresponseDTO request);

    }
}
