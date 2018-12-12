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
    public class ComputersSetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComputersSetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ComputersSets
        public async Task<IActionResult> Index()
        {
            return View(await _context.computers.ToListAsync());
        }

        // GET: ComputersSets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computersSet = await _context.computers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computersSet == null)
            {
                return NotFound();
            }

            return View(computersSet);
        }

        // GET: ComputersSets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComputersSets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Firm,Model,Quantity,Cost,Processor,RAM,VRAM,Graphics")] ComputersSet computersSet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(computersSet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(computersSet);
        }

        // GET: ComputersSets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computersSet = await _context.computers.FindAsync(id);
            if (computersSet == null)
            {
                return NotFound();
            }
            return View(computersSet);
        }

        // POST: ComputersSets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Firm,Model,Quantity,Cost,Processor,RAM,VRAM,Graphics")] ComputersSet computersSet)
        {
            if (id != computersSet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(computersSet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComputersSetExists(computersSet.Id))
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
            return View(computersSet);
        }

        // GET: ComputersSets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computersSet = await _context.computers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computersSet == null)
            {
                return NotFound();
            }

            return View(computersSet);
        }

        // POST: ComputersSets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computersSet = await _context.computers.FindAsync(id);
            _context.computers.Remove(computersSet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComputersSetExists(int id)
        {
            return _context.computers.Any(e => e.Id == id);
        }
    }
}
