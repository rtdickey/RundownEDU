namespace RundownEDU.Models.School;

public class Person : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
}
