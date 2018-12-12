using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InternetMarketWEB.Data;
using InternetMarketWEB.Models;

namespace InternetMarketWEB.Controllers
{
    public class StreetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StreetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Streets
        public async Task<IActionResult> Index()
        {
            return View(await _context.streets.ToListAsync());
        }

        // GET: Streets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var streets = await _context.streets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (streets == null)
            {
                return NotFound();
            }

            return View(streets);
        }

        // GET: Streets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Streets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Country,City,Region,NameStreen")] Streets streets)
        {
            if (ModelState.IsValid)
            {
                _context.Add(streets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(streets);
        }

        // GET: Streets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var streets = await _context.streets.FindAsync(id);
            if (streets == null)
            {
                return NotFound();
            }
            return View(streets);
        }

        // POST: Streets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Country,City,Region,NameStreen")] Streets streets)
        {
            if (id != streets.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(streets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StreetsExists(streets.Id))
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
            return View(streets);
        }

        // GET: Streets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var streets = await _context.streets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (streets == null)
            {
                return NotFound();
            }

            return View(streets);
        }

        // POST: Streets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var streets = await _context.streets.FindAsync(id);
            _context.streets.Remove(streets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StreetsExists(int id)
        {
            return _context.streets.Any(e => e.Id == id);
        }
    }
}
