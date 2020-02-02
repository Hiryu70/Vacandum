using System;
using Newtonsoft.Json;
#pragma warning disable 1591
#pragma warning disable SA1600

namespace Vacandum.Services.Dto
{
	public class Item
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("premium")]
		public bool Premium { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("department")]
		public object Department { get; set; }

		[JsonProperty("has_test")]
		public bool HasTest { get; set; }

		[JsonProperty("response_letter_required")]
		public bool ResponseLetterRequired { get; set; }

		[JsonProperty("area")]
		public Area Area { get; set; }

		[JsonProperty("salary")]
		public Salary Salary { get; set; }

		[JsonProperty("type")]
		public TypeClass Type { get; set; }

		[JsonProperty("address")]
		public Address Address { get; set; }

		[JsonProperty("response_url")]
		public object ResponseUrl { get; set; }

		[JsonProperty("sort_point_distance")]
		public object SortPointDistance { get; set; }

		[JsonProperty("employer")]
		public Employer Employer { get; set; }

		[JsonProperty("published_at")]
		public string PublishedAt { get; set; }

		[JsonProperty("created_at")]
		public string CreatedAt { get; set; }

		[JsonProperty("archived")]
		public bool Archived { get; set; }

		[JsonProperty("apply_alternate_url")]
		public Uri ApplyAlternateUrl { get; set; }

		[JsonProperty("insider_interview")]
		public InsiderInterview InsiderInterview { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }

		[JsonProperty("alternate_url")]
		public Uri AlternateUrl { get; set; }

		[JsonProperty("relations")]
		public object[] Relations { get; set; }

		[JsonProperty("snippet")]
		public Snippet Snippet { get; set; }

		[JsonProperty("contacts")]
		public Contacts Contacts { get; set; }

		[JsonProperty("page")]
		public long Page { get; set; }
	}
}