using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarShop.Data;
using CarShop.Models;
using Microsoft.AspNetCore.Authorization;

namespace CarShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminPartsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public AdminPartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminParts
        public async Task<IActionResult> Index(string search)
        {
            ViewBag.Search = search;
            if (!String.IsNullOrEmpty(search))
            {
                var Parts = from Part in _context.Part
                            select Part;

                Parts = Parts.Where(Part => Part.Brand.Contains(search));

                return View(Parts.ToList());
            }
            return View(await _context.Part.ToListAsync());
        }

        // GET: AdminParts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var part = await _context.Part
                .FirstOrDefaultAsync(m => m.PartID == id);
            if (part == null)
            {
                return NotFound();
            }

            return View(part);
        }

        // GET: AdminParts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminParts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartID,Name,Brand,ModelCompatibility,Year_Of_Manufacture,Price,ImageUrl")] Part part)
        {
            if (ModelState.IsValid)
            {
                _context.Add(part);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(part);
        }

        // GET: AdminParts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var part = await _context.Part.FindAsync(id);
            if (part == null)
            {
                return NotFound();
            }
            return View(part);
        }

        // POST: AdminParts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PartID,Name,Brand,ModelCompatibility,Year_Of_Manufacture,Price,ImageUrl")] Part part)
        {
            if (id != part.PartID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(part);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartExists(part.PartID))
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
            return View(part);
        }

        // GET: AdminParts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var part = await _context.Part
                .FirstOrDefaultAsync(m => m.PartID == id);
            if (part == null)
            {
                return NotFound();
            }

            return View(part);
        }

        // POST: AdminParts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var part = await _context.Part.FindAsync(id);
            if (part != null)
            {
                _context.Part.Remove(part);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartExists(int id)
        {
            return _context.Part.Any(e => e.PartID == id);
        }
    }
}
