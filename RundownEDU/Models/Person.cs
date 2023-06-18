using RundownEDU.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace RundownEDU.Models;

public class Person
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
