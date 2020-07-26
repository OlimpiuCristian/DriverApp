using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly DataContext _context;
        public DriversController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetDrivers()
        {
            var drivers = await _context.Drivers.ToListAsync();
            return Ok(drivers);
        }
        [HttpGet("{phoneNumber}")]
        public async Task<IActionResult> GetDriver(int phoneNumber)
        {
            var drivers = await _context.Drivers.FirstOrDefaultAsync(x => x.PhoneNumber == phoneNumber);
            return Ok(drivers);
        }
    }
}