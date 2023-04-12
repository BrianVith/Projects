using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SurfsUpIdentity.Data;
using SurfsUpIdentity.Models;
using SurfsUpIdentity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace SurfsUpIdentity.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]")]
    public class BorrowEquipmentController : Controller
    {
        private readonly ILogger<BorrowEquipmentController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IHttpClientFactory _clientFactory;

        public BorrowEquipmentController(ILogger<BorrowEquipmentController> logger, ApplicationDbContext context, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _context = context;
            _clientFactory = clientFactory;
        }
        [HttpGet]
        [Route("Index")]
        [Route("Index/{searchString}")]
        public async Task<IActionResult> Index(string searchString)
        {
            var client = _clientFactory.CreateClient("equipments");

            IEnumerable<Equipment> equipmentList = await client.GetFromJsonAsync<IEnumerable<Equipment>>("https://localhost:44318/Equipment/get");

            //List<Equipment> equipmentList = await _context.Equipments.ToListAsync();
            // Eager loading: (lazy loading initialized in startup.cs)
            //List<Equipment> equipmentList = await _context.Equipments.Include(x => x.User).ThenInclude(x => x.City).ToListAsync();

            ViewData["searchBoardType"] = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipmentList = equipmentList.Where(e => e.BoardType.ToString().ToLower().Contains(searchString.ToLower()));
            }

            return View(equipmentList.ToList());
        }

        [Route("Payment")]
        public async Task<IActionResult> Payment(Equipment equipment)
        {
            equipment.User =  (await _context.Equipments.FindAsync(equipment.EquipmentId)).User;
            equipment.User.City = (await  _context.Users.FindAsync(equipment.User.Id)).City;
            return View(equipment);
        }

        [Route("LenderInfo")]
        public IActionResult LenderInfo(User user)
        {
            return View(user);
        }

        [Route("Partners")]
        public IActionResult Partners()
        {
            //Call Partner APIs
            //Retrieve their equipment
            List<PartnerEquipment> list = new List<PartnerEquipment>();
            //Convert it to PartnerEquipment

            return View(list);
        }
    }
}
