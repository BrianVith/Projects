using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ApiProject.Data;
using ApiProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Controllers
{
    [ApiController]
    [Route("/Equipment")]
    public class EquipmentController : Controller
    {
        private ApiDbContext _dbContext { get; set; }
        public EquipmentController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [Route("get")]
        public async Task<IActionResult> GetAllEquipment()
        {
            var theList = await _dbContext.Equipments.Include(x => x.User).ThenInclude(x => x.City).ToListAsync();
            if (theList.Count !=0)
            {
                var json = JsonSerializer.Serialize<object>(theList);
                return Ok(json);
            }
            return NoContent();
        }
        
        [Route("get/{id}")]
        public async Task<IActionResult> GetEquipment(int id)
        {
            var item = await _dbContext.Equipments.SingleOrDefaultAsync(x => x.EquipmentId == id);
            return Ok(item);
        }
    }
}