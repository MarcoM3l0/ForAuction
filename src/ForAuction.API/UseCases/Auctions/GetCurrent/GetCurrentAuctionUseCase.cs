using ForAuction.API.Contracts;
using ForAuction.API.Entities;

namespace ForAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRpository _repository;

    public GetCurrentAuctionUseCase(IAuctionRpository repository) => _repository = repository;

    public Auction? Execute() => _repository.GetCurrent();
}
