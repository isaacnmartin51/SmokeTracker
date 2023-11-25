using MediatR;
using SmokeTracker.Api.Data;

namespace SmokeTracker.Api.Features.GetSmokeLogs;

internal class GetSmokeLogsQuery : IRequest<IEnumerable<SmokeLog>> { }
