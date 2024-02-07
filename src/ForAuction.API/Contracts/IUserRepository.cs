using ForAuction.API.Entities;

namespace ForAuction.API.Contracts;

public interface IUserRepository
{
    bool ExisteUserWithEmail(string email);
    User GetUserByEmail(string email);
}
