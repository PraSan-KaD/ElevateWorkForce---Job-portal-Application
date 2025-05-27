using ElevateWorkForce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ElevateWorkForce.Data; // Adjust namespace for your DbContext
using ElevateWorkForce.Models; // Adjust namespace for your models

namespace ElevateWorkForce.Controllers
{
    public class JobSeekerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobSeekerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JobSeeker/Index
        public async Task<IActionResult> Index()
        {
            var jobs = await _context.JobDetails
                .Include(j => j.EmployerDetails)  // eager load company info
                .ToListAsync();

            return View(jobs);
        }
    }
}
