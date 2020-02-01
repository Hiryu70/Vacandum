using Newtonsoft.Json;
#pragma warning disable 1591
#pragma warning disable SA1600

namespace Vacandum.Services.Dto
{
	public class Salary
	{
		[JsonProperty("from")]
		public long? From { get; set; }

		[JsonProperty("to")]
		public long? To { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("gross")]
		public bool Gross { get; set; }
	}
}