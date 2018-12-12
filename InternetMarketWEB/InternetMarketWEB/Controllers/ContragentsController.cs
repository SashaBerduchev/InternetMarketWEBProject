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
    public class ContragentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContragentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Contragents
        public async Task<IActionResult> Index()
        {
            return View(await _context.contragents.ToListAsync());
        }

        // GET: Contragents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contragents = await _context.contragents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contragents == null)
            {
                return NotFound();
            }

            return View(contragents);
        }

        // GET: Contragents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contragents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Country,City,Oblast,Region")] Contragents contragents)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contragents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contragents);
        }

        // GET: Contragents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contragents = await _context.contragents.FindAsync(id);
            if (contragents == null)
            {
                return NotFound();
            }
            return View(contragents);
        }

        // POST: Contragents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Country,City,Oblast,Region")] Contragents contragents)
        {
            if (id != contragents.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contragents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContragentsExists(contragents.Id))
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
            return View(contragents);
        }

        // GET: Contragents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contragents = await _context.contragents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contragents == null)
            {
                return NotFound();
            }

            return View(contragents);
        }

        // POST: Contragents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contragents = await _context.contragents.FindAsync(id);
            _context.contragents.Remove(contragents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContragentsExists(int id)
        {
            return _context.contragents.Any(e => e.Id == id);
        }
    }
}
