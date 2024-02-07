using ForAuction.API.Contracts;
using ForAuction.API.Entities;

namespace ForAuction.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{

    private readonly ForAuctionDbContext _dbContext;
    public UserRepository(ForAuctionDbContext dbContext) => _dbContext = dbContext;

    public bool ExisteUserWithEmail(string email)
    {
        return _dbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
}
