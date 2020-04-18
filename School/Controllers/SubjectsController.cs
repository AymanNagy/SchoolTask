using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly AppDpContext Context;

        public SubjectsController(School.Models.AppDpContext context)
        {
            this.Context = context;
        }


        public ViewResult ListOfSubjects()
        {
            return View(Context.tbSubjects);
        }

        [HttpGet]
        public IActionResult NewSubjects()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewSubjects(School.Models.Database.Subjects NewSubjects)
        {
            if (ModelState.IsValid)
            {
                Context.tbSubjects.Add(NewSubjects);
                Context.SaveChanges();
                return RedirectToAction("NewSubjects", "Subjects", new { });
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditSubjects(int SubjectsID)
        {
            var Subject = Context.tbSubjects.FirstOrDefault(x => x.SubjectsID == SubjectsID);

            return View(Subject);
        }


        [HttpPost]
        public RedirectToActionResult EditSubjects(Models.Database.Subjects NewSubjects , int SubjectsID)
        {
            var Subjects = Context.tbSubjects.FirstOrDefault(x => x.SubjectsID == SubjectsID);
            Subjects.SubjectName = NewSubjects.SubjectName;
            Context.tbSubjects.Update(Subjects);
            Context.SaveChanges();
            return RedirectToAction("ListOfSubjects", "Subjects", new { });
        }


        public RedirectToActionResult DeleteSubjects(int SubjectsID)
        {
         
            Context.tbSubjects.Remove(Context.tbSubjects.FirstOrDefault(x => x.SubjectsID == SubjectsID));
            Context.SaveChanges();
            return RedirectToAction("ListOfSubjects", "Subjects", new { });
        }
    }
}