using ForAuction.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ForAuction.API.Controllers;

public class AuctionController : ForAuctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction()
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute();

        if (result is null)
            return NoContent();

        return Ok(result);
    }
}

