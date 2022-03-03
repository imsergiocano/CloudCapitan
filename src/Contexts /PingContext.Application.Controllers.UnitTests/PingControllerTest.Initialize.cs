using Ping.Application.Controllers.Controllers;
using PingContext.Application.Service;
using PingContext.Application.Service.Abstractions;
using Moq;
using Xunit;

namespace PingContext.Application.Controllers.UnitTests;

public partial class PingControllerTest
{
    private PingController systemUnderTests;
    private Mock<IPingService> pingService;

    public PingControllerTest()
    {
        this.pingService = new Mock<IPingService>();
        this.systemUnderTests = new PingController(this.pingService.Object);
     }
}
