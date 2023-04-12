using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiProject.Models
{

        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class AirTemperature
        {
            [JsonPropertyName("dwd")]
            public double Dwd { get; set; }

            [JsonPropertyName("noaa")]
            public double Noaa { get; set; }

            [JsonPropertyName("sg")]
            public double Sg { get; set; }
        }

        public class Gust
        {
            [JsonPropertyName("dwd")]
            public double Dwd { get; set; }

            [JsonPropertyName("noaa")]
            public double Noaa { get; set; }

            [JsonPropertyName("sg")]
            public double Sg { get; set; }
        }

        public class WaterTemperature
        {
            [JsonPropertyName("meto")]
            public double Meto { get; set; }

            [JsonPropertyName("noaa")]
            public double Noaa { get; set; }

            [JsonPropertyName("sg")]
            public double Sg { get; set; }
        }

        public class WaveHeight
        {
            [JsonPropertyName("dwd")]
            public double Dwd { get; set; }

            [JsonPropertyName("fcoo")]
            public double Fcoo { get; set; }

            [JsonPropertyName("icon")]
            public double Icon { get; set; }

            [JsonPropertyName("meteo")]
            public double Meteo { get; set; }

            [JsonPropertyName("noaa")]
            public double Noaa { get; set; }

            [JsonPropertyName("sg")]
            public double Sg { get; set; }
        }

        public class WavePeriod
        {
            [JsonPropertyName("fcoo")]
            public double Fcoo { get; set; }

            [JsonPropertyName("icon")]
            public double Icon { get; set; }

            [JsonPropertyName("meteo")]
            public double Meteo { get; set; }

            [JsonPropertyName("noaa")]
            public double Noaa { get; set; }

            [JsonPropertyName("sg")]
            public double Sg { get; set; }
        }

        public class WindSpeed
        {
            [JsonPropertyName("icon")]
            public double Icon { get; set; }

            [JsonPropertyName("noaa")]
            public double Noaa { get; set; }

            [JsonPropertyName("sg")]
            public double Sg { get; set; }
        }

        public class Hour
        {
            [JsonPropertyName("airTemperature")]
            public AirTemperature AirTemperature { get; set; }

            [JsonPropertyName("gust")]
            public Gust Gust { get; set; }

            [JsonPropertyName("time")]
            public DateTime Time { get; set; }

            [JsonPropertyName("waterTemperature")]
            public WaterTemperature WaterTemperature { get; set; }

            [JsonPropertyName("waveHeight")]
            public WaveHeight WaveHeight { get; set; }

            [JsonPropertyName("wavePeriod")]
            public WavePeriod WavePeriod { get; set; }

            [JsonPropertyName("windSpeed")]
            public WindSpeed WindSpeed { get; set; }
        }

        public class Meta
        {
            [JsonPropertyName("cost")]
            public int Cost { get; set; }

            [JsonPropertyName("dailyQuota")]
            public int DailyQuota { get; set; }

            [JsonPropertyName("end")]
            public string End { get; set; }

            [JsonPropertyName("lat")]
            public double Lat { get; set; }

            [JsonPropertyName("lng")]
            public double Lng { get; set; }

            [JsonPropertyName("params")]
            public List<string> Params { get; set; }

            [JsonPropertyName("requestCount")]
            public int RequestCount { get; set; }

            [JsonPropertyName("start")]
            public string Start { get; set; }
        }

        public class WeatherData
        {
            [JsonPropertyName("hours")]
            public List<Hour> Hours { get; set; }

            [JsonPropertyName("meta")]
            public Meta Meta { get; set; }
        }


    }

