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
    public class CityDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CityDatasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CityDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.cities.ToListAsync());
        }

        // GET: CityDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cityData = await _context.cities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cityData == null)
            {
                return NotFound();
            }

            return View(cityData);
        }

        // GET: CityDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CityDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CountryName")] CityData cityData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cityData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cityData);
        }

        // GET: CityDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cityData = await _context.cities.FindAsync(id);
            if (cityData == null)
            {
                return NotFound();
            }
            return View(cityData);
        }

        // POST: CityDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CountryName")] CityData cityData)
        {
            if (id != cityData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cityData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CityDataExists(cityData.Id))
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
            return View(cityData);
        }

        // GET: CityDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cityData = await _context.cities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cityData == null)
            {
                return NotFound();
            }

            return View(cityData);
        }

        // POST: CityDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cityData = await _context.cities.FindAsync(id);
            _context.cities.Remove(cityData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CityDataExists(int id)
        {
            return _context.cities.Any(e => e.Id == id);
        }
    }
}
