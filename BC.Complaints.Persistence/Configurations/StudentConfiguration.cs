using BC.Complaints.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BC.Complaints.Persistence.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Firstname).HasMaxLength(100);
            builder.Property(s => s.Lastname).HasMaxLength(100);
        }
    }
}
