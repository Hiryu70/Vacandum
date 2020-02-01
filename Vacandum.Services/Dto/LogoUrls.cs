using System;
using Newtonsoft.Json;
#pragma warning disable 1591
#pragma warning disable SA1600

namespace Vacandum.Services.Dto
{
	public class LogoUrls
	{
		[JsonProperty("90")]
		public Uri The90 { get; set; }

		[JsonProperty("240")]
		public Uri The240 { get; set; }

		[JsonProperty("original")]
		public Uri Original { get; set; }
	}
}