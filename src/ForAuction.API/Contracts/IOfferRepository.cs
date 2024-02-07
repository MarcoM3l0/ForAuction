using ForAuction.API.Entities;

namespace ForAuction.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
