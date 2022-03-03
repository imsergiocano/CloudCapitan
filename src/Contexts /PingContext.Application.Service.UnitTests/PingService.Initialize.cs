using PingContext.Application.Service.Abstractions;
using Xunit;

namespace PingContext.Application.Service.UnitTests;

public partial class PingServiceTests 
{
    IPingService systemUnderTest;

    public PingServiceTests()
    {
        this.systemUnderTest = new PingService();
    }
}
