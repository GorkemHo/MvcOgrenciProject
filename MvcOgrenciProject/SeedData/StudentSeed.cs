using MvcOgrenciProject.Entities;

namespace MvcOgrenciProject.SeedData
{
    public class StudentSeed
    {
        public static List<Student> Students = new List<Student>
        {
            new Student() {ID= 1, Name="Student1", GroupID=1 },
            new Student() {ID= 2, Name="Student2", GroupID=1 },
            new Student() {ID= 3, Name="Student3", GroupID=2 },
            new Student() {ID= 4, Name="Student4", GroupID=2 },
            new Student() {ID= 5, Name="Student5", GroupID=3 },
            new Student() {ID= 6, Name="Student6", GroupID=3 },

        };
    }
}
