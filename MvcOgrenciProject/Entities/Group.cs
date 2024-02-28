namespace MvcOgrenciProject.Entities
{
    public class Group : BaseEntity
    {

        public ICollection<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>();
        }
    }
}
