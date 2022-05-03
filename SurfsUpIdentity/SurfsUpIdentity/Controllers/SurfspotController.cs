using Microsoft.AspNetCore.Mvc;
using SurfsUpIdentity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurfsUpIdentity.ViewModels;
using System.Net.Http;
using System.Text;
using System.Net.Mime;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Text.Json;
using SurfsUpIdentity.Models;
using Microsoft.AspNetCore.Identity;
using SurfsUpIdentity.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace SurfsUpIdentity.Controllers
{
    [Route("[controller]")]
    public class SurfspotController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private SurfSpotViewModel _viewModel;
        private UserManager<User> _userManager;

        public SurfspotController(ApplicationDbContext context, IHttpClientFactory clientFactory, UserManager<User> userManager, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _clientFactory = clientFactory;
            _viewModel = new SurfSpotViewModel();
            _userManager = userManager;
            this._hostingEnvironment = hostingEnvironment;

        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {

            List<SurfSpot> surfSpots =_context.SurfSpots.ToList();

            List<SurfSpotViewModel> SurfSpotViewmodels = new List<SurfSpotViewModel>();

            foreach (var spot in surfSpots)
            {
                SurfSpotViewmodels.Add(spot);
            }

            return View(SurfSpotViewmodels);
        }

        [Authorize]
        [Route("AddSurfSpot")]
        public IActionResult AddSurfSpot()
        {
            return View();
        }

        [HttpPost]
        [Route("AddSurfSpot")]
        public async Task<IActionResult> AddSurfSpot(SurfSpotViewModel model)
        {

            if (model.Image != null) //model.Title != null && model.Description != null &&
            {
                await FileHandler.SaveFile(_hostingEnvironment, model);

                _context.SurfSpots.Add(model);
                _context.SaveChanges();
                return Redirect("/Surfspot/Index");
            }
            return View(model);
        }

        [Route("SurfSpot")]
        public async Task<IActionResult> SurfSpot(SurfSpotViewModel surfSpot)
        {
            // Hent vejrdata

            DateTime start = DateTime.Now;
            long UnixStart = ((DateTimeOffset)start).ToUnixTimeSeconds();

            int multiplier = 0;

            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                if (user.IsPremium)
                {
                    multiplier = 10;
                }
                
            }
            
            long UnixEnd = UnixStart + 3600 * multiplier;

            var client = _clientFactory.CreateClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("8b180ae6-2daa-11ec-8169-0242ac130002-8b180b7c-2daa-11ec-8169-0242ac130002");
            var response = await client.GetAsync($"https://api.stormglass.io/v2/weather/point?lat={surfSpot.Latitude}&lng={surfSpot.Longitude}&start={UnixStart}&end={UnixEnd}&params=airTemperature,waveHeight,wavePeriod,waterTemperature,gust,windSpeed&source=noaa");

            surfSpot.weatherData = JsonSerializer.Deserialize<WeatherData>(await response.Content.ReadAsStringAsync());
            
            //TEST SENDER ALLE REVIEWS TIL DET VALGTE SURFSPOT
            
            surfSpot.Reviews = _context.SpotReviews.Where(x=>x.SpotId == surfSpot.SpotID).ToList();

            WeatherDeterminator determinator = new WeatherDeterminator();
            determinator.IsWeatherNice(surfSpot);

            //Sende vejrdata og surfspot til viewet
            

            return View(surfSpot);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitReview(SurfSpotViewModel model)
        {
            //var spotReview = new SpotReview();
            model.SpotReview.Date = DateTime.Now;
            //spotReview.Description = model.SpotReview.Description;
            //spotReview.Title = model.SpotReview.Title;
            model.SpotReview.User = await _userManager.GetUserAsync(User);
            model.SpotReview.SpotId = model.SpotID;
            //spotReview.NumberOfPeople = model.NumberOfPeople;
            //spotReview.WaveQuality = model.WaveQuality;
            model.SpotReview.Image = (await FileHandler.SaveFile(_hostingEnvironment, model)).ImagePath;
            _context.SpotReviews.Add(model.SpotReview);
            _context.SaveChanges();
            model = _context.SurfSpots.Find(model.SpotID);
            return RedirectToAction("SurfSpot",model);
        }
    }
}
