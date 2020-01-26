using Newtonsoft.Json;

namespace Vacandum.Domain.Dto
{
	public class Snippet
	{
		[JsonProperty("requirement")]
		public string Requirement { get; set; }

		[JsonProperty("responsibility")]
		public string Responsibility { get; set; }
	}
}