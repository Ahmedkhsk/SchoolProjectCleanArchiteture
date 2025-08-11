using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entites
{
    public class StudentSubjects
    {
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int studentId { get; set; }
        public Student Student { get; set; } = default!;

        [ForeignKey("Subject")]
        public int subjectId { get; set; }
        public Subject Subject { get; set; } = default!;
    }
}
