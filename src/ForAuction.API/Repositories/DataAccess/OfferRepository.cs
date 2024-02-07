using ForAuction.API.Contracts;
using ForAuction.API.Entities;
using System;

namespace ForAuction.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly ForAuctionDbContext _dbContext;
    public OfferRepository(ForAuctionDbContext dbContext) => _dbContext = dbContext;

    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}
