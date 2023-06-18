namespace RundownEDU.Models.Rundown;

public interface IEvent
{
    int Id { get; set; }
    string Name { get; set; }
    DateTime StartDate { get; set; }
    IRundown? Rundown { get; set; }
}