using System.Text.Json;
using System.Threading.Tasks;
using ApiProject.Data;
using ApiProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Controllers
{
    [ApiController]
    [Route("/spots")]
    public class SpotController : Controller
    {
        private ApiDbContext _dbContext;

        public SpotController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [Route("getSpots")]
        public async Task<IActionResult> GetSpots()
        {
           var spots= await _dbContext.SurfSpots.ToListAsync();
           var json = JsonSerializer.Serialize(spots);
           return Ok(json);
        }
        
        [Route("getSpots/{id}")]
        public async Task<IActionResult> GetSpots(int id)
        {
            var item =await _dbContext.SurfSpots.SingleOrDefaultAsync(x => x.Id == id);
            var json = JsonSerializer.Serialize(item);
            return Ok(json);
        }
    }
}