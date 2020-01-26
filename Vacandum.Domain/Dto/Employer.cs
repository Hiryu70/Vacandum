using System;
using Newtonsoft.Json;

namespace Vacandum.Domain.Dto
{
	public class Employer
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }

		[JsonProperty("alternate_url")]
		public Uri AlternateUrl { get; set; }

		[JsonProperty("logo_urls")]
		public LogoUrls LogoUrls { get; set; }

		[JsonProperty("vacancies_url")]
		public Uri VacanciesUrl { get; set; }

		[JsonProperty("trusted")]
		public bool Trusted { get; set; }
	}
}