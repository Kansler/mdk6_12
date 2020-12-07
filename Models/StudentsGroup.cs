using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProject.Models
{
    public class StudentsGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Specialty_id { get; set; }
        public Specialty Specialty { get; set; }
    }
}
