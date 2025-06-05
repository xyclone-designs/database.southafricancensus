
namespace Database.SouthAfricanCensus.Enums
{
	[SQLite.StoreAsText]
	public enum EmploymentStatus
	{
		EmployedSelf,
		EmployedFullTime,
		EmployedPartTime,
		Unemployed,
		NotLooking,
	}
}