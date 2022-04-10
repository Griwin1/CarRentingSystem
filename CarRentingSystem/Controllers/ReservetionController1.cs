using CarRentingSystem.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace CarRentingSystem.Controllers
{
    [Authorize]
    public class ReservetionController1 : Controller
    {
        private object _httpContextAccessor;
        private readonly SupercarDbContext _context;


        public ReservetionController1(SupercarDbContext context)
        {
            _context = context;
        }


        public IActionResult Create(int carid)
        {
            ViewBag.CarId = carid;
            return View();

        }


      /* public async Task<IActionResult> Index()
        {

            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var reservation = _context.Reservations
                .Include(r => r.CarId)
                 .ThenInclude(s => s.DealerId)
                .Include(r => r.Types)
                .Where(x => x.Car.UserId == userId)
                .ToList();
            return View(await _context.Reservations.Where(x => x.CarId.DealerId == DealerId).ToListAsync());

        }*/

    }
}
