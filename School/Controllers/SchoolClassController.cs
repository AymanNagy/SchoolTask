using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class SchoolClassController : Controller
    {
        private readonly AppDpContext Context;

        public SchoolClassController(School.Models.AppDpContext context)
        {
            this.Context = context;
        }


        public ViewResult ListOfSchool(School.Models.ViewModel.SchoolClassViewModel SVM)
        {
            SVM.ListOfSchools = Context.tbSchools;
            return View(SVM);
        }

        
        public ViewResult ListOfClass(School.Models.ViewModel.SchoolClassViewModel SVM)
        {

            SVM.ListOfSchoolClass = Context.tbSchoolClass.Where(x => x.school.SchoolID == SVM.SchoolID);
            return View(SVM);
        }

        [HttpGet]
        public ViewResult NewSchoolClass(School.Models.ViewModel.SchoolClassViewModel SVM)
        {
          
            return View (SVM);

        }

        [HttpPost]
        public IActionResult NewSchoolClass(Models.Database.SchoolClass schoolClass , int SchoolID)
        {
            schoolClass.SchoolID = SchoolID;
            Context.tbSchoolClass.Add(schoolClass);
            Context.SaveChanges();
            return RedirectToAction("NewSchoolClass", "SchoolClass", new { SchoolID = schoolClass.SchoolID });

        }

        
     

        [HttpGet]
        public IActionResult EditSchoolClass (int SchoolClassID)
        {
            var SchoolClass = Context.tbSchoolClass.FirstOrDefault(x => x.SchoolClassID == SchoolClassID);

            return View(SchoolClass);
        }


        [HttpPost]
        public RedirectToActionResult EditSchoolClass (Models.Database.SchoolClass NewSchoolClass, int SchoolClassID)
        {
            var SchoolClass = Context.tbSchoolClass.FirstOrDefault(x => x.SchoolClassID == SchoolClassID);
            SchoolClass.ClassName = NewSchoolClass.ClassName;
            Context.tbSchoolClass.Update(SchoolClass);
            Context.SaveChanges();


            Models.ViewModel.SchoolClassViewModel SCV = new Models.ViewModel.SchoolClassViewModel();
            SCV.SchoolID = SchoolClass.SchoolID;
            return RedirectToAction("ListOfClass", "SchoolClass",SCV);
        }


        public RedirectToActionResult DeleteSchoolClass(int SchoolClassID)
        {

            var SchoolClass = Context.tbSchoolClass.FirstOrDefault(x => x.SchoolClassID == SchoolClassID);

            Context.tbSchoolClass.Remove(SchoolClass)
                ;
            Context.SaveChanges();

            Models.ViewModel.SchoolClassViewModel SCV = new Models.ViewModel.SchoolClassViewModel();
            SCV.SchoolID = SchoolClass.SchoolID;

            return RedirectToAction("ListOfClass", "SchoolClass", SCV);
        }
    }
}