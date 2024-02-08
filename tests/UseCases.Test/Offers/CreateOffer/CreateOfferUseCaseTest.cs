using Bogus;
using FluentAssertions;
using ForAuction.API.communication.Requests;
using ForAuction.API.Contracts;
using ForAuction.API.Entities;
using ForAuction.API.Services;
using ForAuction.API.UseCases.Offers.CreateOffer;
using Moq;
using Xunit;

namespace UseCases.Test.Offers.CreateOffer;
public class CreateOfferUseCaseTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Success(int itemId)
    {
        //ARRANGE
        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(request => request.Price, f => f.Random.Decimal(50, 3000)).Generate();

        var offerRepository = new Mock<IOfferRepository>();
        var loggedUser = new Mock<ILoggedUser>();
        loggedUser.Setup(i => i.User()).Returns(new User());

        var useCase = new CreateOfferUseCase(loggedUser.Object, offerRepository.Object);

        //ACT
        var act = () => useCase.Execute(itemId, request);

        //ASSERT
        act.Should().NotThrow();
    }
}
