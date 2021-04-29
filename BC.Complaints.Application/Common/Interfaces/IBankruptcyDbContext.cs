using BC.Complaints.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BC.Complaints.Application.Common.Interfaces
{
    public interface IBankruptcyDbContext
    {
         DbSet<Student> Students { get; set; }
    }
}
