using Microsoft.AspNetCore.Mvc;
using Ping.Application.Controllers.Constants;
using PingContext.Application.Service.Abstractions;

namespace Ping.Application.Controllers.Controllers;

[Route(Routes.PingControllerRoot)]
public class PingController : ControllerBase
{

    private readonly IPingService pingService;


    public PingController(IPingService pingService) => this.pingService = pingService;


    [HttpGet]
    [Produces("application/json")]
    public IActionResult GetPing()
    {
        return Ok(new { PingResponse = this.pingService.GetPing() });
    }
}

