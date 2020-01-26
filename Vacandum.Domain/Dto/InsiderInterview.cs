using System;
using Newtonsoft.Json;

namespace Vacandum.Domain.Dto
{
	public class InsiderInterview
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }
	}
}