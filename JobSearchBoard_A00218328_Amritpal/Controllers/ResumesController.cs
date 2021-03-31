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
    public class ResumesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResumesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Resumes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Resume.ToListAsync());
        }

        // GET: Resumes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resume = await _context.Resume
                .FirstOrDefaultAsync(m => m.ID == id);
            if (resume == null)
            {
                return NotFound();
            }

            return View(resume);
        }

        // GET: Resumes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Resumes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ResName,JobId,Education,Experience")] Resume resume)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resume);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resume);
        }

        // GET: Resumes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resume = await _context.Resume.FindAsync(id);
            if (resume == null)
            {
                return NotFound();
            }
            return View(resume);
        }

        // POST: Resumes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ResName,JobId,Education,Experience")] Resume resume)
        {
            if (id != resume.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resume);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResumeExists(resume.ID))
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
            return View(resume);
        }

        // GET: Resumes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resume = await _context.Resume
                .FirstOrDefaultAsync(m => m.ID == id);
            if (resume == null)
            {
                return NotFound();
            }

            return View(resume);
        }

        // POST: Resumes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resume = await _context.Resume.FindAsync(id);
            _context.Resume.Remove(resume);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResumeExists(int id)
        {
            return _context.Resume.Any(e => e.ID == id);
        }
    }
}
