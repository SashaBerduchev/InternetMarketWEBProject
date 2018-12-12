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
    public class ZakazPokupatelyasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZakazPokupatelyasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ZakazPokupatelyas
        public async Task<IActionResult> Index()
        {
            return View(await _context.zakazPokupatelyas.ToListAsync());
        }

        // GET: ZakazPokupatelyas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zakazPokupatelya = await _context.zakazPokupatelyas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zakazPokupatelya == null)
            {
                return NotFound();
            }

            return View(zakazPokupatelya);
        }

        // GET: ZakazPokupatelyas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ZakazPokupatelyas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Organization,Contragent,Sklad,Ysluga,Data")] ZakazPokupatelya zakazPokupatelya)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zakazPokupatelya);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zakazPokupatelya);
        }

        // GET: ZakazPokupatelyas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zakazPokupatelya = await _context.zakazPokupatelyas.FindAsync(id);
            if (zakazPokupatelya == null)
            {
                return NotFound();
            }
            return View(zakazPokupatelya);
        }

        // POST: ZakazPokupatelyas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Organization,Contragent,Sklad,Ysluga,Data")] ZakazPokupatelya zakazPokupatelya)
        {
            if (id != zakazPokupatelya.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zakazPokupatelya);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZakazPokupatelyaExists(zakazPokupatelya.Id))
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
            return View(zakazPokupatelya);
        }

        // GET: ZakazPokupatelyas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zakazPokupatelya = await _context.zakazPokupatelyas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zakazPokupatelya == null)
            {
                return NotFound();
            }

            return View(zakazPokupatelya);
        }

        // POST: ZakazPokupatelyas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zakazPokupatelya = await _context.zakazPokupatelyas.FindAsync(id);
            _context.zakazPokupatelyas.Remove(zakazPokupatelya);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZakazPokupatelyaExists(int id)
        {
            return _context.zakazPokupatelyas.Any(e => e.Id == id);
        }
    }
}
