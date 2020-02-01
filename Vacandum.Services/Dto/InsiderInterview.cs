using System;
using Newtonsoft.Json;
#pragma warning disable 1591
#pragma warning disable SA1600

namespace Vacandum.Services.Dto
{
	public class InsiderInterview
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }
	}
}