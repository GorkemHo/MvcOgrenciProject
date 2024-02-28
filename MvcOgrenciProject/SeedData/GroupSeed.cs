using System.Text.RegularExpressions;

namespace MvcOgrenciProject.SeedData
{
    public class GroupSeed
    {
        public static List<Group> Groups = new List<Group>
        {
            new Group() {ID= 1, Name="Group1" },
            new Group() {ID= 2, Name="Group2" },
            new Group() {ID= 3, Name="Group3" },

        };
    }
}
