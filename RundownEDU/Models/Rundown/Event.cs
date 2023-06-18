namespace RundownEDU.Models.Rundown;

public class Event : IEvent
{
    public int Id { get; set; }
    public string Name { get; set; } = "New Event";
    public DateTime StartDate { get; set; }
    public IRundown? Rundown { get; set; }
}