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
    public class Job_PostingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Job_PostingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Job_Posting
        public async Task<IActionResult> Index()
        {
            return View(await _context.Job_Posting.ToListAsync());
        }

        // GET: Job_Posting/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job_Posting = await _context.Job_Posting
                .FirstOrDefaultAsync(m => m.ID == id);
            if (job_Posting == null)
            {
                return NotFound();
            }

            return View(job_Posting);
        }

        // GET: Job_Posting/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Job_Posting/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Jobtitle,JobSkills,JobDescription,PostingDate,EmployerId")] Job_Posting job_Posting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(job_Posting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(job_Posting);
        }

        // GET: Job_Posting/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job_Posting = await _context.Job_Posting.FindAsync(id);
            if (job_Posting == null)
            {
                return NotFound();
            }
            return View(job_Posting);
        }

        // POST: Job_Posting/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Jobtitle,JobSkills,JobDescription,PostingDate,EmployerId")] Job_Posting job_Posting)
        {
            if (id != job_Posting.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(job_Posting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Job_PostingExists(job_Posting.ID))
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
            return View(job_Posting);
        }

        // GET: Job_Posting/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job_Posting = await _context.Job_Posting
                .FirstOrDefaultAsync(m => m.ID == id);
            if (job_Posting == null)
            {
                return NotFound();
            }

            return View(job_Posting);
        }

        // POST: Job_Posting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var job_Posting = await _context.Job_Posting.FindAsync(id);
            _context.Job_Posting.Remove(job_Posting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Job_PostingExists(int id)
        {
            return _context.Job_Posting.Any(e => e.ID == id);
        }
    }
}
