using Newtonsoft.Json;
#pragma warning disable 1591
#pragma warning disable SA1600

namespace Vacandum.Services.Dto
{
	public class Metro
	{
		[JsonProperty("station_name")]
		public string StationName { get; set; }

		[JsonProperty("line_name")]
		public string LineName { get; set; }

		[JsonProperty("station_id")]
		public string StationId { get; set; }

		[JsonProperty("line_id")]
		public long LineId { get; set; }

		[JsonProperty("lat")]
		public double Lat { get; set; }

		[JsonProperty("lng")]
		public double Lng { get; set; }
	}
}