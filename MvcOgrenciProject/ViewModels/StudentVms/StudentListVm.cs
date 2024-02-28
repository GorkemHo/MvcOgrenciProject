using MvcOgrenciProject.Entities;

namespace MvcOgrenciProject.ViewModels.StudentVms
{
    public class StudentListVm
    {
        private readonly Student _student;
        private readonly string _groupName;

        public StudentListVm(string groupName,Student student)
        {
            _student = student;
            _groupName = groupName;            
        }

        public string FirstName => _student.Name;
        public string LastName => _student.LastName;
        public string GroupName => _groupName;
        public int Id => _student.Id;
    }
}
