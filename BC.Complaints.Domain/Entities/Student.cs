namespace BC.Complaints.Domain.Entities
{
    public class Student : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
    }
}
