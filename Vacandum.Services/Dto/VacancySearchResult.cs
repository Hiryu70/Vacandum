using System;
using Newtonsoft.Json;

namespace Vacandum.Services.Dto
{
	public class VacancySearchResult
	{
		[JsonProperty("items")]
		public Item[] Items { get; set; }

		[JsonProperty("found")]
		public long Found { get; set; }

		[JsonProperty("pages")]
		public long Pages { get; set; }

		[JsonProperty("per_page")]
		public long PerPage { get; set; }

		[JsonProperty("page")]
		public long Page { get; set; }

		[JsonProperty("clusters")]
		public object Clusters { get; set; }

		[JsonProperty("arguments")]
		public object Arguments { get; set; }

		[JsonProperty("alternate_url")]
		public Uri AlternateUrl { get; set; }
	}
}