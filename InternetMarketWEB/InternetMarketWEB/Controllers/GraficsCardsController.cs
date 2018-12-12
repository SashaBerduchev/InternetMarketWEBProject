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
    public class GraficsCardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GraficsCardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GraficsCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.grafics.ToListAsync());
        }

        // GET: GraficsCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graficsCard = await _context.grafics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (graficsCard == null)
            {
                return NotFound();
            }

            return View(graficsCard);
        }

        // GET: GraficsCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GraficsCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,GraphicsCore,Cores,Herts,VRAM,Voltage")] GraficsCard graficsCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(graficsCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(graficsCard);
        }

        // GET: GraficsCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graficsCard = await _context.grafics.FindAsync(id);
            if (graficsCard == null)
            {
                return NotFound();
            }
            return View(graficsCard);
        }

        // POST: GraficsCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,GraphicsCore,Cores,Herts,VRAM,Voltage")] GraficsCard graficsCard)
        {
            if (id != graficsCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(graficsCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GraficsCardExists(graficsCard.Id))
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
            return View(graficsCard);
        }

        // GET: GraficsCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graficsCard = await _context.grafics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (graficsCard == null)
            {
                return NotFound();
            }

            return View(graficsCard);
        }

        // POST: GraficsCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var graficsCard = await _context.grafics.FindAsync(id);
            _context.grafics.Remove(graficsCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GraficsCardExists(int id)
        {
            return _context.grafics.Any(e => e.Id == id);
        }
    }
}
