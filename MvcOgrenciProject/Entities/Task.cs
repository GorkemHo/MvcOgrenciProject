namespace MvcOgrenciProject.Entities
{
    public class Task : BaseEntity
    {
        public string Description { get; set; }

        public ICollection<StudentTask> StudentTasks { get; set; }

        public Task()
        {
            StudentTasks = new HashSet<StudentTask>();
        }
    }
}
