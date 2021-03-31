using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobSearchBoard_A00218328_Amritpal.Data;
using JobSearchBoard_A00218328_Amritpal.Models;

namespace JobSearchBoard_A00218328_Amritpal.Controllers
{
    public class Saved_SearchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Saved_SearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Saved_Search
        public async Task<IActionResult> Index()
        {
            return View(await _context.Saved_Search.ToListAsync());
        }

        // GET: Saved_Search/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saved_Search = await _context.Saved_Search
                .FirstOrDefaultAsync(m => m.ID == id);
            if (saved_Search == null)
            {
                return NotFound();
            }

            return View(saved_Search);
        }

        // GET: Saved_Search/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Saved_Search/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CandidateId,JobId")] Saved_Search saved_Search)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saved_Search);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(saved_Search);
        }

        // GET: Saved_Search/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saved_Search = await _context.Saved_Search.FindAsync(id);
            if (saved_Search == null)
            {
                return NotFound();
            }
            return View(saved_Search);
        }

        // POST: Saved_Search/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CandidateId,JobId")] Saved_Search saved_Search)
        {
            if (id != saved_Search.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saved_Search);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Saved_SearchExists(saved_Search.ID))
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
            return View(saved_Search);
        }

        // GET: Saved_Search/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saved_Search = await _context.Saved_Search
                .FirstOrDefaultAsync(m => m.ID == id);
            if (saved_Search == null)
            {
                return NotFound();
            }

            return View(saved_Search);
        }

        // POST: Saved_Search/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saved_Search = await _context.Saved_Search.FindAsync(id);
            _context.Saved_Search.Remove(saved_Search);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Saved_SearchExists(int id)
        {
            return _context.Saved_Search.Any(e => e.ID == id);
        }
    }
}
