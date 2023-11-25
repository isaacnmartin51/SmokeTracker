using SmokeTracker.Api.Data;

namespace SmokeTracker.Api.Features.AddSmokeLog;


internal record AddSmokeLogRequest(
    DateTime SmokeDate,
    int DurationInMinutes,
    Scale Craving,
    Scale Satisfaction,
    string Notes);
