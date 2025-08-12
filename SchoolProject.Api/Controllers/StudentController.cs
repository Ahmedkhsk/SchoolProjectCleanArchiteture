using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Queries.Models;

namespace SchoolProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        #region Fields

        #endregion

        #region Constructors
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion


        #region Action Methods
        [HttpGet("/student/List")]
        public async Task<IActionResult> GetStudents()
        {
            var response = await _mediator.Send(new GetStudentListQuery());
            if (response == null || !response.Any())
            {
                return NotFound("No students found.");
            }
            return Ok(response);
        }
        #endregion

    }
}
