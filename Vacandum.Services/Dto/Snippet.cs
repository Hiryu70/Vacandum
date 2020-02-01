using Newtonsoft.Json;
#pragma warning disable 1591
#pragma warning disable SA1600

namespace Vacandum.Services.Dto
{
	public class Snippet
	{
		[JsonProperty("requirement")]
		public string Requirement { get; set; }

		[JsonProperty("responsibility")]
		public string Responsibility { get; set; }
	}
}