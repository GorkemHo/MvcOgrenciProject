using MvcOgrenciProject.Entities;

namespace MvcOgrenciProject.ViewModels.StudentVms
{
    public class StudentUpdateVm
    {
        private readonly Group _group;

        public StudentUpdateVm(Group group)
        {
            _group = group;
        }

        public int GroupID => _group.Id;

        public string GroupName => _group.Name;
    }
}
