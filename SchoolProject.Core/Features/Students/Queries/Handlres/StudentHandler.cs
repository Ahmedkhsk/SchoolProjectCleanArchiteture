using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.Entites;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlres
{
    public class StudentHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {

        #region Fields
        private readonly IStudentService _studentService;
        #endregion

        #region Constructors
        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        #endregion

        #region Handle Methods
        public async Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetStudentsAsync();
        }
        #endregion

    }
}
