using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using SurfsUpIdentity.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SurfsUpIdentity.Enums;

namespace SurfsUpIdentity.ViewModels
{
    public class SurfSpotViewModel
    {
        [Required(ErrorMessage = "Titel er påkrævet")]
        [DisplayName("Titel")]
        [StringLength(100, MinimumLength = 5)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Indtast en postnummer")]
        [DisplayName("Postnummer")]
        public int PostCode { get; set; }

        [Required(ErrorMessage = "Indtast latitude")]
        [DisplayName("Latitude")]
        public string Latitude { get; set; }

        [Required(ErrorMessage = "Indtast longitude")]
        [DisplayName("Longitude")]
        public string Longitude { get; set; }

        [Required(ErrorMessage = "Indtast by")]
        [DisplayName("By")]
        public string City { get; set; }

        [Required(ErrorMessage = "Der skal vælges et billede")]
        [FileExtensions(Extensions = "jpeg,jpg,png", ErrorMessage = "Billedet skal være i jpg eller png format")]
        [DisplayName("Billede")]
        public IFormFile Image { get; set; }

        public string ImagePath { get; set; }
        public WeatherData weatherData {get;set;}

        public List<SpotReview> Reviews { get; set; }

        public SpotReview SpotReview { get; set; }

        public int SpotID { get; set; }
        


        public bool IsNice = false;
        
        public static implicit operator SurfSpotViewModel(SurfSpot surfSpot)
        {
            return new SurfSpotViewModel()
            {
                Title = surfSpot.SpotName,
                PostCode = surfSpot.PostCode,
                Longitude = surfSpot.Longitude,
                Latitude = surfSpot.Latitude,
                City = surfSpot.City,
                ImagePath = surfSpot.ImagePath,
                SpotID = surfSpot.Id
            };
        }

        public static implicit operator SurfSpot(SurfSpotViewModel surfSpotViewModel)
        {
            return new SurfSpot()
            {
                SpotName = surfSpotViewModel.Title,
                PostCode = surfSpotViewModel.PostCode,
                Longitude = surfSpotViewModel.Longitude,
                Latitude = surfSpotViewModel.Latitude,
                City = surfSpotViewModel.City,
                ImagePath = surfSpotViewModel.ImagePath,
                Id = surfSpotViewModel.SpotID
            };
        }
    }
}