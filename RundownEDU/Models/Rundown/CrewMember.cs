using RundownEDU.Models.School;

namespace RundownEDU.Models.Rundown
{
	public class CrewMember : IPerson
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = String.Empty;
	}
}
