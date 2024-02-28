using MvcOgrenciProject.Entities;

namespace MvcOgrenciProject.ViewModels.GroupVms
{
    public class GroupUpdateVm
    {
        private readonly Group _group;
        public GroupUpdateVm(Group group)
        {
            _group = group;
        }
        public int GroupID => _group.Id;
        public string GroupName => _group.Name;
    }
}
