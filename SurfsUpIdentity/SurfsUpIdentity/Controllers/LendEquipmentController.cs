using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Server.Features;
using SurfsUpIdentity.Data;
using SurfsUpIdentity.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using SurfsUpIdentity.Areas.Identity.Pages.Account;
using SurfsUpIdentity.Models;
using SurfsUpIdentity.Utility;

namespace SurfsUpIdentity.Controllers
{
    [Route("[controller]")]
    public class LendEquipmentController : Controller
    {
        public ApplicationDbContext DbContext { get; set; }
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly UserManager<User> _userManager;

        public bool IsAuthenticated { get; set; }

        public LendEquipmentController(ApplicationDbContext applicationDbContext, IWebHostEnvironment hostingEnvironment, UserManager<User> userManager)
        {
            DbContext = applicationDbContext;
            this._hostingEnvironment = hostingEnvironment;
            _userManager = userManager;

        }

        [Authorize]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Index")]
        public async Task<IActionResult> Index(LendOutEquipmentViewModel model)
        {

            if (model.Picture!=null) //model.Title != null && model.Description != null &&
            {
                long size = model.Picture.Sum(f => f.Length);

                model.UserId = _userManager.GetUserId(User);

                await FileHandler.SaveFile(_hostingEnvironment, model);

                DbContext.Equipments.Add(model);
                DbContext.SaveChanges();
                return Redirect("/BorrowEquipment/Index");
            }

            return View(model);
        }
        

    }
}
    

