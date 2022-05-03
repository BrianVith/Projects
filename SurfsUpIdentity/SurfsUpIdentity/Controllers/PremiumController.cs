using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SurfsUpIdentity.Data;
using SurfsUpIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfsUpIdentity.Controllers
{
    [Route("[controller]")]
    public class PremiumController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<User> _userManager;

        public PremiumController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("ActivatePremium")]
        public async Task<IActionResult> ActivatePremium()
        {
            var user = await _userManager.GetUserAsync(User);
            Task.WaitAll();
            user.IsPremium = true;
            _context.Update(user);
            _context.SaveChanges();
            return Redirect(Url.Action("Index","Home"));
        }

        [Route("DeactivePremium")]
        public async Task<IActionResult> DeactivatePremium()
        {
            var user = await _userManager.GetUserAsync(User);
            Task.WaitAll();
            user.IsPremium = false;
            _context.Update(user);
            _context.SaveChanges();
            return Redirect(Url.Action("Index", "Home"));
        }

    }
}
