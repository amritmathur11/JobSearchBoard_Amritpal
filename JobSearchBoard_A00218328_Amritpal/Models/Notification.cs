using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JobSearchBoard_A00218328_Amritpal.Interface;


namespace JobSearchBoard_A00218328_Amritpal.Models
{
    public class Notification : KeyAutoIncrement
    {
        public int ID { get; set; }

        public int EmployerId { get; set; }

        public int JobId { get; set; }

        public string NotificationText{ get; set; }


        public int ReadCount { get; set; }
}
}
