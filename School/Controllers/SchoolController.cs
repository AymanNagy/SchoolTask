using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class SchoolController : Controller
    {
        private readonly AppDpContext Context;

        public SchoolController(School.Models.AppDpContext context)
        {
            this.Context = context;
        }


        public ViewResult ListOfSchool()
        {
            return View(Context.tbSchools);
        }

        [HttpGet]
        public IActionResult NewSchool()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewSchool(School.Models.Database.Schools NewSchool)
        {
            if (ModelState.IsValid)
            {
                Context.tbSchools.Add(NewSchool);
                Context.SaveChanges();
                return RedirectToAction("NewSchool", "School", new { });
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditSchool (int SchoolID)
        {
            var School = Context.tbSchools.FirstOrDefault(x => x.SchoolID == SchoolID);

            return View(School);
        }


        [HttpPost]
        public RedirectToActionResult EditSchool(Models.Database.Schools NewSchool , int SchoolID)
        {
            var School = Context.tbSchools.FirstOrDefault(x => x.SchoolID == SchoolID);
            School.SchoolName = NewSchool.SchoolName;
            Context.tbSchools.Update(School);
            Context.SaveChanges();
            return RedirectToAction("ListOfSchool", "School", new { });
        }


        public RedirectToActionResult DeleteSchool(int SchoolID)
        {
         
            Context.tbSchools.Remove(Context.tbSchools.FirstOrDefault(x => x.SchoolID == SchoolID)
                );
            Context.SaveChanges();
            return RedirectToAction("ListOfSchool", "School", new { });
        }
    }
}