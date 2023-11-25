using MediatR;

namespace SmokeTracker.Api.Features.AddSmokeLog;

internal class AddSmokeLogCommand(AddSmokeLogRequest addSmokeLogRequest) : IRequest
{
    public AddSmokeLogRequest AddSmokeLogRequest { get; } = addSmokeLogRequest;
}
