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
    public class TivisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TivisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tivis
        public async Task<IActionResult> Index()
        {
            return View(await _context.tivis.ToListAsync());
        }

        // GET: Tivis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tivis = await _context.tivis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tivis == null)
            {
                return NotFound();
            }

            return View(tivis);
        }

        // GET: Tivis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tivis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Firm,Model,Quantity,Cost")] Tivis tivis)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tivis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tivis);
        }

        // GET: Tivis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tivis = await _context.tivis.FindAsync(id);
            if (tivis == null)
            {
                return NotFound();
            }
            return View(tivis);
        }

        // POST: Tivis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Firm,Model,Quantity,Cost")] Tivis tivis)
        {
            if (id != tivis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tivis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TivisExists(tivis.Id))
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
            return View(tivis);
        }

        // GET: Tivis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tivis = await _context.tivis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tivis == null)
            {
                return NotFound();
            }

            return View(tivis);
        }

        // POST: Tivis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tivis = await _context.tivis.FindAsync(id);
            _context.tivis.Remove(tivis);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TivisExists(int id)
        {
            return _context.tivis.Any(e => e.Id == id);
        }
    }
}
