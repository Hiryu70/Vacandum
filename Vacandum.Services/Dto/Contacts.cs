using Newtonsoft.Json;

namespace Vacandum.Services.Dto
{
	public class Contacts
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("phones")]
		public Phone[] Phones { get; set; }
	}
}