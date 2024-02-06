using ForAuction.API.Entities;
using ForAuction.API.Repositories;
using Microsoft.EntityFrameworkCore;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new ForAuctionDbContext();

        var todey = DateTime.Now;

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => todey >= auction.Starts && todey <= auction.Ends);

    }
}
