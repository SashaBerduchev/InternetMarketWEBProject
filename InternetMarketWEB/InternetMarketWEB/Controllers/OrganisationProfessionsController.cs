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
    public class OrganisationProfessionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrganisationProfessionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OrganisationProfessions
        public async Task<IActionResult> Index()
        {
            return View(await _context.organisationProfessions.ToListAsync());
        }

        // GET: OrganisationProfessions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organisationProfession = await _context.organisationProfessions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (organisationProfession == null)
            {
                return NotFound();
            }

            return View(organisationProfession);
        }

        // GET: OrganisationProfessions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrganisationProfessions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CodeKP,Organization")] OrganisationProfession organisationProfession)
        {
            if (ModelState.IsValid)
            {
                _context.Add(organisationProfession);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(organisationProfession);
        }

        // GET: OrganisationProfessions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organisationProfession = await _context.organisationProfessions.FindAsync(id);
            if (organisationProfession == null)
            {
                return NotFound();
            }
            return View(organisationProfession);
        }

        // POST: OrganisationProfessions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CodeKP,Organization")] OrganisationProfession organisationProfession)
        {
            if (id != organisationProfession.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(organisationProfession);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrganisationProfessionExists(organisationProfession.Id))
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
            return View(organisationProfession);
        }

        // GET: OrganisationProfessions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organisationProfession = await _context.organisationProfessions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (organisationProfession == null)
            {
                return NotFound();
            }

            return View(organisationProfession);
        }

        // POST: OrganisationProfessions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var organisationProfession = await _context.organisationProfessions.FindAsync(id);
            _context.organisationProfessions.Remove(organisationProfession);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrganisationProfessionExists(int id)
        {
            return _context.organisationProfessions.Any(e => e.Id == id);
        }
    }
}
