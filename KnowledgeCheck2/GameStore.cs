using System;
using System.Text.Json.Serialization;
namespace GameStore
{
	public class VideoGameConsole
	{
		[JsonInclude]
		public string ConsoleName { get; set; }
        [JsonInclude]
        public string? Manufacturer { get; set; }
        [JsonInclude]
        public int ReleaseYear { get; set; }
        [JsonInclude]
        public int NumberOfButtons { get; set; }
        [JsonInclude]
        public bool HasTouchScreen { get; set; }
	}

	public class HandheldVideoGameConsole : VideoGameConsole
	{
        [JsonInclude]
        public double BatteryLifeInHours { get; set; }
        [JsonInclude]
        public bool HasMultipleScreens { get; set; }

	}


}

