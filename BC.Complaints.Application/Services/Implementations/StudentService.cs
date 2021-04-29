using AutoMapper;
using BC.Complaints.Application.Common.DTO;
using BC.Complaints.Application.Common.Handler;
using BC.Complaints.Application.Common.Interfaces;
using BC.Complaints.Application.Services.Interfaces;
using BC.Complaints.Domain.Entities;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BC.Complaints.Application.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        private readonly IRepository<Student> _studentRepository;
        public StudentService(IMapper mapper, ILogger logger, IRepository<Student> studentRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _studentRepository = studentRepository;
        }

        public async Task<Result<string>> AddStudentAsync(StudentDTO studentDTO)
        {
            try
            {
                Student student = _mapper.Map<Student>(studentDTO);
                student.CreatedAt = DateTime.Now;
                student.CreatedBy = "ahmed";
                student = await _studentRepository.AddAsync(student);
                return Result<string>.Created(student.Id.ToString());
            }
            catch (Exception exp)
            {
                _logger.Error(exp, "Exception in : StudentService/AddStudentAsync");
                return Result<string>.InternalServerError(new string[] { "An error occurred please contact admin" });
            }
        }

        public async Task<Result<IList<StudentDTO>>> GetStudentsAsync()
        {
            try
            {
                var students = await _studentRepository.GetAllAsync();
                return Result<IList<StudentDTO>>.Ok(_mapper.Map<IList<StudentDTO>>(students));
            }
            catch (Exception exp)
            {
                _logger.Error(exp, "Exception in : StudentService/GetStudentsAsync");
                return Result<IList<StudentDTO>>.InternalServerError(new string[] { "An error occurred please contact admin" });
            }
        }
    }
}
