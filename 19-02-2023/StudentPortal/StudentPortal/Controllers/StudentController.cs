using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Data;
using StudentPortal.Models;

namespace StudentPortal.Controllers
{
    public class StudentController : Controller
    {
        private AppDbContext appDbContext;
        public StudentController(AppDbContext dbContext)
        {
            this.appDbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddStudentViewModel addmodel)
        {
            var student = new Student();
            student.Name=addmodel.Name;
            student.Email=addmodel.Email;
            student.Phone=addmodel.Phone;
            student.Subscribed=addmodel.Subscribed;
            appDbContext.students.Add(student);
            appDbContext.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            var students=appDbContext.students.ToList();
            return View(students);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var student = appDbContext.students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var student_update = appDbContext.students.Find(student.Id);
            if(student_update != null)
            {
                student_update.Name = student.Name;
                student_update.Email = student.Email;
                student_update.Phone = student.Phone;
                student_update.Subscribed = student.Subscribed;

                appDbContext.Entry(student_update).State = EntityState.Modified;

                appDbContext.SaveChanges();
                return RedirectToAction("List", "Student");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Student student)
        {
            var student_toDelete = appDbContext.students.Find(student.Id);
            if(student_toDelete != null)
            {
                appDbContext.students.Remove(student_toDelete);
                appDbContext.SaveChanges();
                return RedirectToAction("List", "Student");

            }
            return View();

        }
    }
}
