using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JobSearchBoard_A00218328_Amritpal.Contexts;
using JobSearchBoard_A00218328_Amritpal.Models;

namespace JobSearchBoard_A00218328_Amritpal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly JobSearchBoard_A00218328_Amritpal.Contexts.Context _context;

        public IndexModel(JobSearchBoard_A00218328_Amritpal.Contexts.Context context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; }
        

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate.ToListAsync();
        }

        public IList<Employer> Employer { get; set; }
        public IList<Job_Application> Job_Application { get; set; }
        public IList<Job_Posting> Job_Posting { get; set; }
        public IList<Notification> Notification { get; set; }
        public IList<Resume> Resume { get; set; }
        public IList<Saved_Search> Saved_Search { get; set; }




    }
}
