using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entites
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Addresse { get; set; } = default!;
        public string Phone { get; set; } = default!;
       
        [ForeignKey("Department")]
        public int departmentId { get; set; }
        public Department Department { get; set; } = default!;
    }
}
