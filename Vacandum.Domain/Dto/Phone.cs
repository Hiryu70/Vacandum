using Newtonsoft.Json;

namespace Vacandum.Domain.Dto
{
	public class Phone
	{
		[JsonProperty("comment")]
		public string Comment { get; set; }

		[JsonProperty("city")]
		public long City { get; set; }

		[JsonProperty("number")]
		public long Number { get; set; }

		[JsonProperty("country")]
		public long Country { get; set; }
	}
}