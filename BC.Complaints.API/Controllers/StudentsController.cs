using BC.Complaints.API.Common.Handler;
using BC.Complaints.Application.Common.DTO;
using BC.Complaints.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BC.Complaints.API.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public async Task<ResponseActionResult<string>> CreateStudentAsync([FromBody] StudentDTO student)
        {
            return new ResponseActionResult<string>(await _studentService.AddStudentAsync(student));
        }

        [HttpGet]
        public async Task<ResponseActionResult<IList<StudentDTO>>> GetStudentsAsync()
        {
            return new ResponseActionResult<IList<StudentDTO>>(await _studentService.GetStudentsAsync());
        }
    }
}
