using ApplicationAPI.Entities;

namespace ApplicationAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
