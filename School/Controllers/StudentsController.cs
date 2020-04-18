using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDpContext Context;

        public StudentsController(School.Models.AppDpContext context)
        {
            this.Context = context;
        }


        public ViewResult ListOfSchool()
        {
            return View(Context.tbSchools);
        }

        
        public ViewResult ListOfClass(int SchoolID)
        {
            Models.ViewModel.StudentsViewModel SVM = new Models.ViewModel.StudentsViewModel();
            SVM.ListOfSchoolClass = Context.tbSchoolClass.Where(x => x.school.SchoolID == SchoolID);
            return View(SVM);
        }

        public ViewResult ListOfStudent (School.Models.ViewModel.StudentsViewModel SVM , int CLassID )
        {
            SVM.SchoolClassID = CLassID;
            SVM.ListOfStudents = Context.tbStudents.Where(x => x.SchoolClassID == SVM.SchoolClassID);
            return View(SVM);
        }


        [HttpGet]
        public ViewResult NewStudent(School.Models.ViewModel.StudentsViewModel SVM )
        {
            
            return View (SVM);

        }

        [HttpPost]
        public IActionResult NewStudent(Models.Database.Students Students, int SchoolClassID)
        {
            Students.SchoolClassID= SchoolClassID;
            Context.tbStudents.Add(Students);
            Context.SaveChanges();
            School.Models.ViewModel.StudentsViewModel SVM = new Models.ViewModel.StudentsViewModel();
            SVM.SchoolClassID = SchoolClassID;
            return RedirectToAction("NewStudent", "Students", SVM);

        }

        
     

        [HttpGet]
        public IActionResult EditStudent (int StudentID)
        {
            var Student = Context.tbStudents.FirstOrDefault(x => x.StudentID == StudentID);

            return View(Student);
        }


        [HttpPost]
        public RedirectToActionResult EditStudent(Models.Database.Students NewStudent, int StudentID)
        {
            var student = Context.tbStudents.FirstOrDefault(x => x.StudentID == StudentID);
            student.StudentName = NewStudent.StudentName;
            Context.tbStudents.Update(student);
            Context.SaveChanges();
            return RedirectToAction("ListOfStudent", "Students", new { CLassID = student.SchoolClassID });
        }


        public RedirectToActionResult DeleteStudent(int StudentID)
        {

            var student = Context.tbStudents.FirstOrDefault(x => x.StudentID == StudentID);

            Context.tbStudents.Remove(student);
            Context.SaveChanges();

            return RedirectToAction("ListOfStudent", "Students", new { CLassID = student.SchoolClassID } );

        }
    }
}