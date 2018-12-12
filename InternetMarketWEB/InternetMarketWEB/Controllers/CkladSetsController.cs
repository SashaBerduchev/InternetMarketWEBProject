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
    public class CkladSetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CkladSetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CkladSets
        public async Task<IActionResult> Index()
        {
            return View(await _context.cklads.ToListAsync());
        }

        // GET: CkladSets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ckladSet = await _context.cklads
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ckladSet == null)
            {
                return NotFound();
            }

            return View(ckladSet);
        }

        // GET: CkladSets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CkladSets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type,Organisation,Oblast,City,Street")] CkladSet ckladSet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ckladSet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ckladSet);
        }

        // GET: CkladSets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ckladSet = await _context.cklads.FindAsync(id);
            if (ckladSet == null)
            {
                return NotFound();
            }
            return View(ckladSet);
        }

        // POST: CkladSets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,Organisation,Oblast,City,Street")] CkladSet ckladSet)
        {
            if (id != ckladSet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ckladSet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CkladSetExists(ckladSet.Id))
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
            return View(ckladSet);
        }

        // GET: CkladSets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ckladSet = await _context.cklads
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ckladSet == null)
            {
                return NotFound();
            }

            return View(ckladSet);
        }

        // POST: CkladSets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ckladSet = await _context.cklads.FindAsync(id);
            _context.cklads.Remove(ckladSet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CkladSetExists(int id)
        {
            return _context.cklads.Any(e => e.Id == id);
        }
    }
}
