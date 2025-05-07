
namespace SchoolManagment.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderType Gender { get; set; } = 0;
    }
}
