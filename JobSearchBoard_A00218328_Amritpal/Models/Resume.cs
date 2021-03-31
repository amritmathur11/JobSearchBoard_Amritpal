using JobSearchBoard_A00218328_Amritpal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace JobSearchBoard_A00218328_Amritpal.Models
{
    public class Resume : KeyAutoIncrement
    {
        public int ID { get; set; }
        [Display(Name = "Resume Name")]
        public string ResName { get; set; }

        public int JobId { get; set; }

        public string Education { get; set; }

        public string Experience { get; set; }
    }
}
