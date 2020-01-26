using Newtonsoft.Json;

namespace Vacandum.Services.Dto
{
	public class TypeClass
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}