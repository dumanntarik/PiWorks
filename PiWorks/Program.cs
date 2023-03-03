using Microsoft.EntityFrameworkCore;

using PiWorks.Data.Efcore;
using System;
using System.IO;
using System.Linq;

class MyClass
{
	static void Main(string[] args)
	{
		//////answer 4

		//var lines = File.ReadAllLines("country_vaccination_stats.csv");
		//List<Country> records = new List<Country>();

		//for (int i = 1; i < lines.Length; i++)
		//{

		//	var fields = lines[i].Split(',');
		//	if (fields[2] == "")
		//	{
		//		fields[2] = "0";
		//	}

		//	var record = new Country
		//	{
		//		Country1 = fields[0].ToString(),
		//		Date = fields[1].ToString(),
		//		DailyVaccinations = int.Parse(fields[2]),
		//		Vaccines = fields[3].ToString(),
		//	};


		//	records.Add(record);

		//}
		using (var db = new answer())
		{
			//db.AddRange(records);

			//var _countriesThatHaveValidVaccination = db.Countries.Where(x => x.DailyVaccinations > 0).GroupBy(y => y.Country1).Select(z => new { Name = z.Key,minWithoutZero=z.Min(a=>a.DailyVaccinations) }).ToList();
			//foreach (var country in _countriesThatHaveValidVaccination)
			//{
			//	var _minDailyVaccinations = db.Countries.Where(x => x.DailyVaccinations == 0 && x.Country1 == country.Name).ToList();
			//	foreach (var day in _minDailyVaccinations)
			//	{
			//		day.DailyVaccinations = country.minWithoutZero;
			//		Console.WriteLine(country.minWithoutZero + " " + day.Country1);
			//	}

			//};


			//var avgTopThreeCountry = db.Countries.GroupBy(a => a.Country1).OrderByDescending(b=>b.Average(c=>c.DailyVaccinations)).Select(d => new { Country = d.Key, AvgDailyVaccinations = d.Average(x => x.DailyVaccinations) }).Take(3).ToList();

			//         foreach (var item in avgTop3Country)
			//         {
			//             Console.WriteLine(item.AvgDailyVaccinations+" "+item.Country);
			//         }



			db.SaveChanges();
		}
	}
}



