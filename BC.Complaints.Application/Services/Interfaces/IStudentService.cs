using BC.Complaints.Application.Common.DTO;
using BC.Complaints.Application.Common.Handler;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BC.Complaints.Application.Services.Interfaces
{
    public interface IStudentService
    {
        Task<Result<string>> AddStudentAsync(StudentDTO student);
        Task<Result<IList<StudentDTO>>> GetStudentsAsync();
    }
}
