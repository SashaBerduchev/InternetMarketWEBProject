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
    public class DogovorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DogovorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dogovors
        public async Task<IActionResult> Index()
        {
            return View(await _context.dogovors.ToListAsync());
        }

        // GET: Dogovors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogovor = await _context.dogovors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dogovor == null)
            {
                return NotFound();
            }

            return View(dogovor);
        }

        // GET: Dogovors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dogovors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Dogovor dogovor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dogovor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dogovor);
        }

        // GET: Dogovors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogovor = await _context.dogovors.FindAsync(id);
            if (dogovor == null)
            {
                return NotFound();
            }
            return View(dogovor);
        }

        // POST: Dogovors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Dogovor dogovor)
        {
            if (id != dogovor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dogovor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DogovorExists(dogovor.Id))
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
            return View(dogovor);
        }

        // GET: Dogovors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogovor = await _context.dogovors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dogovor == null)
            {
                return NotFound();
            }

            return View(dogovor);
        }

        // POST: Dogovors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dogovor = await _context.dogovors.FindAsync(id);
            _context.dogovors.Remove(dogovor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DogovorExists(int id)
        {
            return _context.dogovors.Any(e => e.Id == id);
        }
    }
}
