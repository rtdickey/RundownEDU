namespace RundownEDU.Models.Rundown;

public class Rundown : IRundown
{
	public int Id { get; set; }
	public string Title { get; set; } = "New Rundown";
	public string? Description { get; set; }
}
