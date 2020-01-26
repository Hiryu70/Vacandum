using System;
using Newtonsoft.Json;

namespace Vacandum.Domain.Dto
{
	public class Area
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }
	}
}