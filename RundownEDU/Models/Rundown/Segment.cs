using RundownEDU.Enums;

namespace RundownEDU.Models.Rundown;

public class Segment
{
	public int Id { get; private set; }
	public string Title { get; set; } = "New Segment";
	public string? Page { get; set; }
	public int OrderId { get; set; }
	public TimeSpan? EstimatedDuration { get; set; }
	public TimeSpan? ActualDuration { get; set; }
	public DateTime? FrontTime { get; set; }
	public DateTime? BackTime { get; set; }
}
