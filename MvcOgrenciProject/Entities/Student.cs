namespace MvcOgrenciProject.Entities
{
    public class Student : BaseEntity
    {
        public string LastName { get; set; }
        public int GroupID { get; set; }
        public Group Group { get; set; }

        public ICollection<StudentTask> StudentTasks { get; set; }

        public Student()
        {
            StudentTasks = new HashSet<StudentTask>();
        }
    }
}
