using MediatR;

namespace SmokeTracker.Api.Features.AddSmokeLog;

internal static class AddSmokeLogEndpoint
{
    internal static void MapAddSmokeLogEndpoint(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPost("/SmokeLogs", (AddSmokeLogRequest request, IMediator mediator) => mediator.Send(new AddSmokeLogCommand(request)));
    }
}
