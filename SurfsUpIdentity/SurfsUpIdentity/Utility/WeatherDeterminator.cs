using SurfsUpIdentity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfsUpIdentity.Utility
{
    public class WeatherDeterminator
    {
        public void IsWeatherNice(SurfSpotViewModel surfspot)
        {
            //Beregen om surfspottet er godt til surfing i øjeblikket
            double waveHeight = 0;
            double AirTemp = 0;
            double WaterTemp = 0;
            double WavePeriod = 0;
            double windSpeed = 0;


            foreach (var item in surfspot.weatherData.Hours)
            {
                waveHeight += item.WaveHeight.Noaa;
                AirTemp += item.AirTemperature.Noaa;
                WaterTemp += item.WaterTemperature.Noaa;
                WavePeriod += item.WavePeriod.Noaa;
                windSpeed += item.WindSpeed.Noaa;
            }
            int numberOfHours = surfspot.weatherData.Hours.Count;

            waveHeight = waveHeight / numberOfHours;
            AirTemp = AirTemp / numberOfHours;
            WaterTemp = WaterTemp / numberOfHours;
            WavePeriod = WavePeriod / numberOfHours;
            windSpeed = windSpeed / numberOfHours;
            
            if (3 >= waveHeight && waveHeight >= 1 && WavePeriod >= 7 && AirTemp > 3 && WaterTemp > 3 && windSpeed <= 12)
            {
                surfspot.IsNice = true;
            }
        }
    }
}
