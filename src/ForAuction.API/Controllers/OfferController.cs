using ForAuction.API.communication.Requests;
using ForAuction.API.Filters;
using ForAuction.API.UseCases.Offers.CreateOffer;
using Microsoft.AspNetCore.Mvc;

namespace ForAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]

public class OfferController : ForAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    
    public IActionResult CreateOffers(
        [FromRoute]int itemId, 
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
