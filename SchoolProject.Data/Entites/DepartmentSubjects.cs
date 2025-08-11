using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entites
{
    public class DepartmentSubjects
    {
        public int Id { get; set; }

        [ForeignKey("Department")]
        public int departmentId { get; set; }
        public Department Department { get; set; } =default!;

        [ForeignKey("Subject")]
        public int subjectId { get; set; }
        public Subject Subject { get; set; } = default!;

    }
}
