using Marten;
using MediatR;
using SmokeTracker.Api.Data;

namespace SmokeTracker.Api.Features.GetSmokeLogs;

internal class GetSmokeLogsHandler(IQuerySession session) : IRequestHandler<GetSmokeLogsQuery, IEnumerable<SmokeLog>>
{
    public async Task<IEnumerable<SmokeLog>> Handle(GetSmokeLogsQuery request, CancellationToken cancellationToken)
    {
        return await session.Query<SmokeLog>().ToListAsync();
    }
}
