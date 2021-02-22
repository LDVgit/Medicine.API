using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medicine.API.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public Employee Employeer { get; set; }
        public Specialty Physician { get; set; }
        public string Qualification { get; set; }

    }
}
