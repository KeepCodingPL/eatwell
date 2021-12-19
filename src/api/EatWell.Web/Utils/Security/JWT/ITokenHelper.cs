using EatWell.API.Models;


namespace EatWell.API.Utils.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(UserModel user);
    }
}
