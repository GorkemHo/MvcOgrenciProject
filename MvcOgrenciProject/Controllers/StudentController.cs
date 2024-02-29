using Microsoft.AspNetCore.Mvc;
using MvcOgrenciProject.Entities;
using MvcOgrenciProject.SeedData;
using System.Drawing.Drawing2D;

namespace MvcOgrenciProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = StudentSeed.Students.ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            ViewBag.Gruplar = GroupSeed.Groups.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.Id = StudentSeed.Students.Max(x => x.Id) + 1;
            
            StudentSeed.Students.Add(student);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int studentId)
        {
            var student = StudentSeed.Students.FirstOrDefault(x => x.Id == studentId);
            if (student != null)
            {
                StudentSeed.Students.Remove(student);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Update(int studentId)
        {
            Student student = StudentSeed.Students.FirstOrDefault(x => x.Id == studentId);
            ViewBag.StudentId = studentId;
            ViewBag.StudentName = student.Name.ToString();
            ViewBag.StudentLastName = student.LastName.ToString();

            Group grp = new Group()
            {
                Name = GroupSeed.Groups.First(x => x.Id == student.GroupID).Name,
                Id = student.GroupID
            };

            student.Group = grp;

            ViewBag.StudentGroupName = student.Group.Name.ToString(); //:(
            
            ViewBag.Groups = GroupSeed.Groups.ToList();

            ViewBag.Student = student;

            return View(student);
        }

        [HttpPost]
        public IActionResult Update2(IFormCollection yeniDegerler)
        {
            int Id = Convert.ToInt32(yeniDegerler["aydi"]);
            Student student = StudentSeed.Students.FirstOrDefault(x => x.Id == Id);

            student.Name = yeniDegerler["ad"].ToString();
            student.LastName = yeniDegerler["soyad"].ToString();
            student.GroupID = int.Parse(yeniDegerler["grup"]);
            student.Group.Name = GroupSeed.Groups.First(x => x.Id == student.GroupID).Name.ToString();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Detay(int studentId)
        {
            Student student = StudentSeed.Students.FirstOrDefault(x => x.Id == studentId);
            return View(student);
        }
        
    }
}
