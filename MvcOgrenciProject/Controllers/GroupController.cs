﻿using Microsoft.AspNetCore.Mvc;
using MvcOgrenciProject.Entities;
using MvcOgrenciProject.SeedData;
using MvcOgrenciProject.ViewModels.GroupVms;
using MvcOgrenciProject.ViewModels.StudentVms;
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

        public IActionResult Delete(int groupId)
        {
            var groupDelete = GroupSeed.Groups.FirstOrDefault(g => g.Id == groupId);
            if (groupDelete != null)
            {
                GroupSeed.Groups.Remove(groupDelete);
            }

            return RedirectToAction("GroupList");
        }

        [HttpPost]
        public IActionResult Update(int groupId)
        {
            Group group = GroupSeed.Groups.FirstOrDefault(x => x.Id == groupId);
            ViewBag.GroupId = groupId;
            ViewBag.Grup = GroupSeed.Groups.ToList();

            return View(group);
        }

        [HttpPost]
        public IActionResult Update2(IFormCollection yeniDeger)
        {
            int Id = Convert.ToInt32(yeniDeger["grup"]);
            Group group = GroupSeed.Groups.FirstOrDefault(x => x.Id == Id);

            group.Name = yeniDeger["yeniisim"].ToString();


            return RedirectToAction("GroupList");
        }

        public IActionResult StudentTaskList(int id) 
        { 
            Student student = StudentSeed.Students.FirstOrDefault(s=>s.Id == id);
            Group group = GroupSeed.Groups.FirstOrDefault(g => g.Id == student.GroupID);
            List<int> studenttasks = StudentTaskSeed.StudentTasks.Where(t => t.StudentID == id).Select(t=>t.TaskID).ToList();
            List<Entities.Task> tasks= TaskSeed.Tasks.Where(t=>studenttasks.Contains(t.Id)).ToList();
            StudentTaskListVm studentTask= new StudentTaskListVm(tasks,student,group.Name);
            return View(studentTask);
        }
    }
}
