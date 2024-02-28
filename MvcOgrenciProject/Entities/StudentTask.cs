namespace MvcOgrenciProject.Entities
{
    public class StudentTask : BaseEntity
    {
        public int StudentID { get; set; }

        public Student Student { get; set; }

        public int TaskID { get; set; }

        public Task Task { get; set; }
    }
}
