using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entites;
using SchoolProject.Infrastructure.Abstract;
using SchoolProject.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        #region Fields
        private readonly DBContext _dbContext;
        #endregion

        #region Constructors
        public StudentRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Handel Methods
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }
        #endregion



    }
}
