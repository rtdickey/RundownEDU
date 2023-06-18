namespace RundownEDU.Models.School;

public interface IPerson
{
	int Id { get; set; }
	string FirstName { get; set; }
    string LastName { get; set; }
}