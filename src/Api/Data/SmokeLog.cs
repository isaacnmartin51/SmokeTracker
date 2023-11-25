namespace SmokeTracker.Api.Data;

public class SmokeLog
{
    public int Id { get; set; }
    public DateTime SmokeDate { get; set; }
    public int DurationInMinutes { get; set; }
    public Scale Craving { get; set; }
    public Scale Satisfaction { get; set; }
    public string Notes { get; set; }
}
