using ForAuction.API.Entities;

namespace ForAuction.API.Contracts;

public interface IAuctionRpository
{
    Auction? GetCurrent();
}
