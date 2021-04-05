using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace NewtonsoftRecordIssues
{
	class Program
	{
		static void Main()
		{
			var r = new MyRecord(Gender.Male);

			Console.WriteLine(JsonConvert.SerializeObject(r));

			var c = new MyClass { Gender = Gender.Male };

			Console.WriteLine(JsonConvert.SerializeObject(c));
		}
	}

	public enum Gender
	{
		Male,
		Female
	}


	public record MyRecord([JsonConverter(typeof(StringEnumConverter))] Gender Gender);

	public class MyClass {[JsonConverter(typeof(StringEnumConverter))] public Gender Gender { get; init; } }
}
