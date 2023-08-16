using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewPortfolio.Data.Profile;

public class Info
{
	public string Name { get; init; } = "Arthur de Castro Geromello";

	public int Age { get; init; } = GetAge();


	public static int GetAge()
	{
		DateTime birthDate = new DateTime(1999, 4, 13);
		DateTime currentDate = DateTime.Now;

		int age = currentDate.Year - birthDate.Year;

		if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
		{
			age--;
		}

		return age;
	}
}
