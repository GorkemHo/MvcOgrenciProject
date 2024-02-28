using MvcOgrenciProject.Entities;

namespace MvcOgrenciProject.ViewModels.StudentVms
{
    public class StudentDetailVm
    {
        private readonly Student _student;

        public StudentDetailVm(Student student)
        {
            _student = student;
        }

        public string Name => _student.Name;
        public string LastName => _student.LastName;
    }
}
