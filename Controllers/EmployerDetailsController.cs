using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ElevateWorkForce.Data;
using ElevateWorkForce.Models;

namespace ElevateWorkForce.Controllers
{
    public class EmployerDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployerDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmployerDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployerDetails.ToListAsync());
        }

        // GET: EmployerDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employerDetails = await _context.EmployerDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employerDetails == null)
            {
                return NotFound();
            }

            return View(employerDetails);
        }

        // GET: EmployerDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployerDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,Phone,PrimaryContactPerson,Email,UserId")] EmployerDetails employerDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employerDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employerDetails);
        }

        // GET: EmployerDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employerDetails = await _context.EmployerDetails.FindAsync(id);
            if (employerDetails == null)
            {
                return NotFound();
            }
            return View(employerDetails);
        }

        // POST: EmployerDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address,Phone,PrimaryContactPerson,Email,UserId")] EmployerDetails employerDetails)
        {
            if (id != employerDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employerDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployerDetailsExists(employerDetails.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employerDetails);
        }

        // GET: EmployerDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employerDetails = await _context.EmployerDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employerDetails == null)
            {
                return NotFound();
            }

            return View(employerDetails);
        }

        // POST: EmployerDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employerDetails = await _context.EmployerDetails.FindAsync(id);
            if (employerDetails != null)
            {
                _context.EmployerDetails.Remove(employerDetails);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployerDetailsExists(int id)
        {
            return _context.EmployerDetails.Any(e => e.Id == id);
        }
    }
}
