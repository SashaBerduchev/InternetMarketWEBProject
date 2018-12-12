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
    public class DocForPainsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DocForPainsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DocForPains
        public async Task<IActionResult> Index()
        {
            return View(await _context.docForPains.ToListAsync());
        }

        // GET: DocForPains/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docForPain = await _context.docForPains
                .FirstOrDefaultAsync(m => m.Id == id);
            if (docForPain == null)
            {
                return NotFound();
            }

            return View(docForPain);
        }

        // GET: DocForPains/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DocForPains/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Organization,Contragent,DataLoad,DataLoad1,Dataload2,Dataload3")] DocForPain docForPain)
        {
            if (ModelState.IsValid)
            {
                _context.Add(docForPain);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(docForPain);
        }

        // GET: DocForPains/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docForPain = await _context.docForPains.FindAsync(id);
            if (docForPain == null)
            {
                return NotFound();
            }
            return View(docForPain);
        }

        // POST: DocForPains/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Organization,Contragent,DataLoad,DataLoad1,Dataload2,Dataload3")] DocForPain docForPain)
        {
            if (id != docForPain.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(docForPain);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocForPainExists(docForPain.Id))
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
            return View(docForPain);
        }

        // GET: DocForPains/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docForPain = await _context.docForPains
                .FirstOrDefaultAsync(m => m.Id == id);
            if (docForPain == null)
            {
                return NotFound();
            }

            return View(docForPain);
        }

        // POST: DocForPains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var docForPain = await _context.docForPains.FindAsync(id);
            _context.docForPains.Remove(docForPain);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocForPainExists(int id)
        {
            return _context.docForPains.Any(e => e.Id == id);
        }
    }
}
