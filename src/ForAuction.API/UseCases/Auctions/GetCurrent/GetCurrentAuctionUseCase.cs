using ForAuction.API.Contracts;
using ForAuction.API.Entities;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRpository _repository;

    public GetCurrentAuctionUseCase(IAuctionRpository repository) => _repository = repository;

    public Auction? Execute() => _repository.GetCurrent();
}
