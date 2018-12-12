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
    public class TabletsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TabletsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tablets
        public async Task<IActionResult> Index()
        {
            return View(await _context.tablets.ToListAsync());
        }

        // GET: Tablets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablets = await _context.tablets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tablets == null)
            {
                return NotFound();
            }

            return View(tablets);
        }

        // GET: Tablets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tablets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Model,Processor,RAM,GPU,Resolution,Battery")] Tablets tablets)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tablets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tablets);
        }

        // GET: Tablets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablets = await _context.tablets.FindAsync(id);
            if (tablets == null)
            {
                return NotFound();
            }
            return View(tablets);
        }

        // POST: Tablets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Model,Processor,RAM,GPU,Resolution,Battery")] Tablets tablets)
        {
            if (id != tablets.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tablets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabletsExists(tablets.Id))
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
            return View(tablets);
        }

        // GET: Tablets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablets = await _context.tablets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tablets == null)
            {
                return NotFound();
            }

            return View(tablets);
        }

        // POST: Tablets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tablets = await _context.tablets.FindAsync(id);
            _context.tablets.Remove(tablets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabletsExists(int id)
        {
            return _context.tablets.Any(e => e.Id == id);
        }
    }
}
