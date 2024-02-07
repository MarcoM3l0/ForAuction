using ForAuction.API.Contracts;
using ForAuction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ForAuction.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRpository
{

    private readonly ForAuctionDbContext _dbContext;
    public AuctionRepository(ForAuctionDbContext dbContext) => _dbContext = dbContext;

    public Auction? GetCurrent()
    {
        var todey = DateTime.Now;

        return _dbContext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => todey >= auction.Starts && todey <= auction.Ends);

    }
}
