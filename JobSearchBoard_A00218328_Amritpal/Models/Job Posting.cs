using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JobSearchBoard_A00218328_Amritpal.Interface;


namespace JobSearchBoard_A00218328_Amritpal.Models
{
    public class Job_Posting : KeyAutoIncrement
    {
         public int ID { get; set; }
        [Display(Name = "Job Title")]
        public string Jobtitle { get; set; }
        [Display(Name = "Job Skills")]
        public string JobSkills { get; set; }
        [Display(Name = "Job Description")]
        public string JobDescription { get; set; }
        [Display(Name = "Posting Date")]
        public DateTime PostingDate { get; set; }
        public int EmployerId { get; set; }

    }

     
    
}
