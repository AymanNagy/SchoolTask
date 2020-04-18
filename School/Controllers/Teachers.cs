using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class TeachersController : Controller
    {
        private readonly AppDpContext Context;

        public TeachersController(School.Models.AppDpContext context)
        {
            this.Context = context;
        }


        public ViewResult ListOfTeachers()
        {
            return View(Context.tbTeachers);
        }

        [HttpGet]
        public IActionResult NewTeachers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewTeachers(School.Models.Database.Teachers NewTeachers)
        {
            if (ModelState.IsValid)
            {
                Context.tbTeachers.Add(NewTeachers);
                Context.SaveChanges();
                return RedirectToAction("NewTeachers", "Teachers", new { });
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditTeachers(int TeachersID)
        {
            var Teachers = Context.tbTeachers.FirstOrDefault(x => x.TeacherID == TeachersID);

            return View(Teachers);
        }


        [HttpPost]
        public RedirectToActionResult EditTeachers(Models.Database.Teachers NewTeachers, int TeachersID)
        {
            var Teachers= Context.tbTeachers.FirstOrDefault(x => x.TeacherID == TeachersID);
            Teachers.TeacherName = NewTeachers.TeacherName;
            Context.tbTeachers.Update(Teachers);
            Context.SaveChanges();
            return RedirectToAction("ListOfTeachers", "Teachers", new { });
        }


        public RedirectToActionResult DeleteTeachers(int TeachersID)
        {
            Context.tbTeachers.Remove(Context.tbTeachers.FirstOrDefault(x => x.TeacherID == TeachersID) );
            Context.SaveChanges();
            return RedirectToAction("ListOfTeachers", "Teachers", new { });
        }
    }
}