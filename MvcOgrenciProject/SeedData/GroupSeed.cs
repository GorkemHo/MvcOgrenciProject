using System.Text.RegularExpressions;
using MvcOgrenciProject.Entities;
using Group = MvcOgrenciProject.Entities.Group;
namespace MvcOgrenciProject.SeedData
{
    public class GroupSeed
    {
        public static List<Group> Groups = new List<Group>()
        {
            new Group() {Id= 1, Name="Group1" },
            new Group() {Id= 2, Name="Group2" },
            new Group() {Id= 3, Name="Group3" },

        };
    }
}
