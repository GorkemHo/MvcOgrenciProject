using MvcOgrenciProject.Entities;
using System.Text.RegularExpressions;
using Group = MvcOgrenciProject.Entities.Group;

namespace MvcOgrenciProject.ViewModels.GroupVms
{
    public class GroupStudentListVm
    {
        private readonly Group _group;
        private readonly List<Student> _students;

        public GroupStudentListVm(List<Student> students, Group group)
        {
            _group = group;
            _students = students;
        }
        public int GroupID => _group.Id;
        public string GroupName => _group.Name;

        public IEnumerable<Student> Students => _students;
    }
}
