using MvcOgrenciProject.Entities;

namespace MvcOgrenciProject.ViewModels.StudentVms
{
    public class StudentTaskListVm
    {
        private readonly Student _student;
        private readonly List<Entities.Task> _tasks;
        private readonly string _groupName;

        public StudentTaskListVm(List<Entities.Task> tasks,Student student, string groupName)
        {
            _student = student;
            _tasks = tasks;
            _groupName = groupName;
        }

        public string FirstName => _student.Name;
        public string LastName => _student.LastName;
        public string GroupName => _groupName;
        public int GroupId => _student.GroupID;
    }
}
