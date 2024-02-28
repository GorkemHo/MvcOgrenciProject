using Microsoft.AspNetCore.Mvc;
using MvcOgrenciProject.Entities;
using MvcOgrenciProject.SeedData;
using MvcOgrenciProject.ViewModels.GroupVms;
using System.Text.RegularExpressions;
using Group = MvcOgrenciProject.Entities.Group;

namespace MvcOgrenciProject.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult GroupList()
        {
            List<Group> groups = GroupSeed.Groups.ToList();
            List<Student> students = StudentSeed.Students.ToList();
            List<GroupStudentListVm> groupStudentListVms = new List<GroupStudentListVm>();

            groups.ForEach(group =>
            {
                var studentsvm = students.Where(s => s.GroupID == group.Id).ToList();
                groupStudentListVms.Add(new GroupStudentListVm(studentsvm, group));

            });

            ViewData["GroupStudents"] = groupStudentListVms;

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection groupCollection)
        {
            string gName = groupCollection["groupName"].ToString();

            Group group = new Group()
            {
                Name = gName,
            };

            GroupSeed.Groups.Add(group);

            return RedirectToAction("GroupList");
        }

        public IActionResult Delete(int groupid)
        {
            var groupDelete = GroupSeed.Groups.FirstOrDefault(g => g.Id == groupid);
            if (groupDelete != null)
            {
                GroupSeed.Groups.Remove(groupDelete);
            }

            return RedirectToAction("GroupList");
        }


        [HttpPost]
        public IActionResult Update(IFormCollection collection)
        {

            //GroupUpdateVm groupUpdateVm = new GroupUpdateVm()
            //{
                
            //}

            return View();
        }

    }
}
