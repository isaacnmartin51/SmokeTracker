using Marten;
using MediatR;
using SmokeTracker.Api.Data;

namespace SmokeTracker.Api.Features.AddSmokeLog;

internal class AddSmokeLogHandler(IDocumentSession session) : IRequestHandler<AddSmokeLogCommand>
{
    public async Task Handle(AddSmokeLogCommand request, CancellationToken cancellationToken)
    {
        var smokeLog = new SmokeLog()
        {
            SmokeDate = request.AddSmokeLogRequest.SmokeDate,
            DurationInMinutes = request.AddSmokeLogRequest.DurationInMinutes,
            Craving = request.AddSmokeLogRequest.Craving,
            Satisfaction = request.AddSmokeLogRequest.Satisfaction,
            Notes = request.AddSmokeLogRequest.Notes
        };

        session.Store(smokeLog);
        await session.SaveChangesAsync();
    }
}
