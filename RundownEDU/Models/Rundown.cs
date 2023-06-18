using RundownEDU.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace RundownEDU.Models;

public class Rundown
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; } = "New Rundown";
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
}
