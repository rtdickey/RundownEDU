namespace RundownEDU.Interfaces
{
    public interface ISegment
    {
        TimeSpan? ActualDuration { get; set; }
        DateTime? BackTime { get; set; }
        TimeSpan? EstimatedDuration { get; set; }
        DateTime? FrontTime { get; set; }
        int Id { get; }
        int OrderId { get; set; }
        string? Page { get; set; }
        string Title { get; set; }
    }
}