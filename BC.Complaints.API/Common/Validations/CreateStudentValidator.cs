using BC.Complaints.Application.Common.DTO;
using FluentValidation;

namespace BC.Complaints.API.Common.Validations
{
    public class CreateStudentValidator : AbstractValidator<StudentDTO>
    {
        public CreateStudentValidator()
        {
            RuleFor(s => s.Firstname)
                .NotNull()
                .NotEmpty().WithMessage("Firstname is required");

            RuleFor(s => s.Lastname)
                .NotNull()
                .NotEmpty().WithMessage("Lastname is required");
        }
    }
}
