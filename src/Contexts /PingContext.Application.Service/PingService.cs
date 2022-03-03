

using PingContext.Application.Service.Abstractions;

namespace PingContext.Application.Service;
public class PingService : IPingService
{
    public string GetPing()
    {
        return new string("Pong!");
    }
}

