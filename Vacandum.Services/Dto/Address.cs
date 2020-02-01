using Newtonsoft.Json;
#pragma warning disable 1591
#pragma warning disable SA1600

namespace Vacandum.Services.Dto
{
	public class Address
	{
		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("street")]
		public string Street { get; set; }

		[JsonProperty("building")]
		public string Building { get; set; }

		[JsonProperty("description")]
		public object Description { get; set; }

		[JsonProperty("lat")]
		public double? Lat { get; set; }

		[JsonProperty("lng")]
		public double? Lng { get; set; }

		[JsonProperty("raw")]
		public string Raw { get; set; }

		[JsonProperty("metro")]
		public Metro Metro { get; set; }

		[JsonProperty("metro_stations")]
		public Metro[] MetroStations { get; set; }

		[JsonProperty("id")]
		public long Id { get; set; }
	}
}