using MediatR;

namespace SmokeTracker.Api.Features.GetSmokeLogs;

internal static class GetSmokeLogsEndpoint
{
    internal static void MapGetSmokeLogsEndpoint(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/SmokeLogs", (IMediator mediator) => mediator.Send(new GetSmokeLogsQuery()));
    }
}
