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
    public class BankSetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BankSetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BankSets
        public async Task<IActionResult> Index()
        {
            return View(await _context.banks.ToListAsync());
        }

        // GET: BankSets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankSet = await _context.banks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankSet == null)
            {
                return NotFound();
            }

            return View(bankSet);
        }

        // GET: BankSets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BankSets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameBank,Country,City,Region,Street")] BankSet bankSet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bankSet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bankSet);
        }

        // GET: BankSets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankSet = await _context.banks.FindAsync(id);
            if (bankSet == null)
            {
                return NotFound();
            }
            return View(bankSet);
        }

        // POST: BankSets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameBank,Country,City,Region,Street")] BankSet bankSet)
        {
            if (id != bankSet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bankSet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankSetExists(bankSet.Id))
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
            return View(bankSet);
        }

        // GET: BankSets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankSet = await _context.banks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankSet == null)
            {
                return NotFound();
            }

            return View(bankSet);
        }

        // POST: BankSets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bankSet = await _context.banks.FindAsync(id);
            _context.banks.Remove(bankSet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankSetExists(int id)
        {
            return _context.banks.Any(e => e.Id == id);
        }
    }
}
