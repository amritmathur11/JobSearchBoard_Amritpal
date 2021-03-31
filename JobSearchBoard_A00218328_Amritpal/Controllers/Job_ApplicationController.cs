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
    public class Job_ApplicationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Job_ApplicationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Job_Application
        public async Task<IActionResult> Index()
        {
            return View(await _context.Job_Application.ToListAsync());
        }

        // GET: Job_Application/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job_Application = await _context.Job_Application
                .FirstOrDefaultAsync(m => m.ID == id);
            if (job_Application == null)
            {
                return NotFound();
            }

            return View(job_Application);
        }

        // GET: Job_Application/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Job_Application/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CandidateId,JobId,DateApplied")] Job_Application job_Application)
        {
            if (ModelState.IsValid)
            {
                _context.Add(job_Application);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(job_Application);
        }

        // GET: Job_Application/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job_Application = await _context.Job_Application.FindAsync(id);
            if (job_Application == null)
            {
                return NotFound();
            }
            return View(job_Application);
        }

        // POST: Job_Application/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CandidateId,JobId,DateApplied")] Job_Application job_Application)
        {
            if (id != job_Application.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(job_Application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Job_ApplicationExists(job_Application.ID))
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
            return View(job_Application);
        }

        // GET: Job_Application/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job_Application = await _context.Job_Application
                .FirstOrDefaultAsync(m => m.ID == id);
            if (job_Application == null)
            {
                return NotFound();
            }

            return View(job_Application);
        }

        // POST: Job_Application/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var job_Application = await _context.Job_Application.FindAsync(id);
            _context.Job_Application.Remove(job_Application);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Job_ApplicationExists(int id)
        {
            return _context.Job_Application.Any(e => e.ID == id);
        }
    }
}
