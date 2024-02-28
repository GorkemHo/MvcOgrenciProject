using MvcOgrenciProject.Entities;

namespace MvcOgrenciProject.SeedData
{
    public class StudentTaskSeed
    {
        public static List<StudentTask> StudentTasks = new List<StudentTask>()
        {
            new StudentTask() {TaskID= 1, StudentID=1 },
            new StudentTask() {TaskID= 2, StudentID=1 },
            new StudentTask() {TaskID= 3, StudentID=1 },
            new StudentTask() {TaskID= 4, StudentID=1 },
            new StudentTask() {TaskID= 5, StudentID=1 },

            new StudentTask() {TaskID= 1, StudentID=2 },
            new StudentTask() {TaskID= 2, StudentID=2 },
            new StudentTask() {TaskID= 3, StudentID=2 },
            new StudentTask() {TaskID= 4, StudentID=2 },
            new StudentTask() {TaskID= 5, StudentID=2 },


            new StudentTask() {TaskID= 1, StudentID=3 },
            new StudentTask() {TaskID= 2, StudentID=3 },
            new StudentTask() {TaskID= 3, StudentID=3 },
            new StudentTask() {TaskID= 4, StudentID=3 },
            new StudentTask() {TaskID= 5, StudentID=3 },

        };
    }
}
