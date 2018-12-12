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
    public class OblastsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OblastsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Oblasts
        public async Task<IActionResult> Index()
        {
            return View(await _context.oblasts.ToListAsync());
        }

        // GET: Oblasts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oblast = await _context.oblasts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oblast == null)
            {
                return NotFound();
            }

            return View(oblast);
        }

        // GET: Oblasts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Oblasts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,City,Country")] Oblast oblast)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oblast);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oblast);
        }

        // GET: Oblasts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oblast = await _context.oblasts.FindAsync(id);
            if (oblast == null)
            {
                return NotFound();
            }
            return View(oblast);
        }

        // POST: Oblasts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,City,Country")] Oblast oblast)
        {
            if (id != oblast.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oblast);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OblastExists(oblast.Id))
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
            return View(oblast);
        }

        // GET: Oblasts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oblast = await _context.oblasts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oblast == null)
            {
                return NotFound();
            }

            return View(oblast);
        }

        // POST: Oblasts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oblast = await _context.oblasts.FindAsync(id);
            _context.oblasts.Remove(oblast);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OblastExists(int id)
        {
            return _context.oblasts.Any(e => e.Id == id);
        }
    }
}
