using MvcOgrenciProject.Entities;
using Task = MvcOgrenciProject.Entities.Task;    
namespace MvcOgrenciProject.SeedData

{
    public class TaskSeed
    {
        public static List<Task> Tasks = new List<Task>()
        {
            new Task() {Id= 1, Name="Task1",Description="Desciption1" },
            new Task() {Id= 2, Name="Task2",Description="Desciption2" },
            new Task() {Id= 3, Name="Task3",Description="Desciption3" },
            new Task() {Id= 4, Name="Task4",Description="Desciption4" },
            new Task() {Id= 5, Name="Task5",Description="Desciption5" },

        };
    }
}
