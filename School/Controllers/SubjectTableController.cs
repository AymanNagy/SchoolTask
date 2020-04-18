using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Controllers
{
    public class SubjectTableController : Controller
    {
        private readonly AppDpContext Context;

        public SubjectTableController(School.Models.AppDpContext context)
        {
            this.Context = context;
        }


        public ViewResult ListOfSchool()
        {
            return View(Context.tbSchools);
        }

        public ViewResult ListOfClass(int schoolID)
        {
           
            return View(Context.tbSchoolClass.Where(x => x.SchoolID == schoolID));
        }


        public ViewResult ListOFDays(int ClassID)
        {
            Models.ViewModel.SubjectTableViewModel STV = new Models.ViewModel.SubjectTableViewModel();
            var CLass = Context.tbSchoolClass.FirstOrDefault(x => x.SchoolClassID == ClassID);
            STV.SchoolID = CLass.SchoolID;
            STV.ClassID = ClassID;
            STV.ListOfDays = Context.tbDays;
            return View(STV);
        }
        public ViewResult ListOfTeatcherAndSubject(int ClassID, int DayID)
        {
            var SelectedTeatcherAndSubjst = Context.tbSubjectTable.Where(x => x.SchoolClassID == ClassID && x.DayID == DayID);
            Models.ViewModel.SubjectTableViewModel STV = new Models.ViewModel.SubjectTableViewModel();
            STV.ListOFTeactcherSubjects = Context.tbTeachersAndSubject.Where(x => !SelectedTeatcherAndSubjst.Any(z => z.TeachersAndSubjectID == x.TeachersAndSubjectID)).Include(x=>x.Subject).Include(z=>z.teacher);
            STV.DayID = DayID;
            STV.ClassID = ClassID;
            return View(STV);
        }

        public ViewResult ViewTeatcherAndSubject(int ClassID, int DayID)
        {
            var SelectedTeatcherAndSubjst = Context.tbSubjectTable.Where(x => x.SchoolClassID == ClassID && x.DayID == DayID).Include(x => x.TeachersAndSubject).ThenInclude(x => x.teacher).ThenInclude(x=>x.TeachersAndSubjects).ThenInclude(x=>x.Subject);
            return View(SelectedTeatcherAndSubjst);
        }


        public IActionResult AddSubjectToTable(int ClassID, int DayID , int TeatcherAndSubID)
        {
            int Counter = Context.tbSubjectTable.Where(x => x.SchoolClassID == ClassID && x.DayID == DayID).Count();
            if (Counter < 5)
            {
                var NewSubToTable = new Models.Database.SubjectTable() { DayID = DayID, SchoolClassID = ClassID, TeachersAndSubjectID = TeatcherAndSubID };
                Context.tbSubjectTable.Add(NewSubToTable);
                Context.SaveChanges();
                return RedirectToAction("ListOfTeatcherAndSubject", "SubjectTable", new { ClassID = ClassID, DayID = DayID });
            }
            TempData["AlertMessage"] = "Max Number of Subject in Day Per Class is 5";
            return RedirectToAction("ListOfTeatcherAndSubject", "SubjectTable", new { ClassID = ClassID, DayID = DayID });
        }

        public IActionResult DeleteTeatcherAndSubject(int SubjectTableID)
        {
            var SubTable = Context.tbSubjectTable.FirstOrDefault(x => x.SubjectTableID == SubjectTableID);
            Context.tbSubjectTable.Remove(SubTable);
            Context.SaveChanges();
         return RedirectToAction("ViewTeatcherAndSubject", "SubjectTable", new { ClassID = SubTable.SchoolClassID, DayID = SubTable.DayID });

        }

        public ViewResult ClassTableDaily(int DayID, int SchoolID)
        {
            Models.ViewModel.ClassTableDailyViewModel CTDVM = new Models.ViewModel.ClassTableDailyViewModel();
            CTDVM.ListOfSubDay =Context.tbSubjectTable.Where(x => x.DayID == DayID).Include(x=>x.Day).Include(x => x.TeachersAndSubject).ThenInclude(x => x.Subject).Include(x => x.TeachersAndSubject).ThenInclude(x => x.teacher).OrderBy(x => x.SchoolClassID).ToList();
            CTDVM.ListOfClass = Context.tbSchoolClass.Where(x => x.SchoolID == SchoolID).ToList();
            return View(CTDVM);
        }


        public ViewResult ClassTable(int ClassID)
        {
            Models.ViewModel.ClassTableViewModel CTVM = new Models.ViewModel.ClassTableViewModel();

            CTVM.ListOfSubSat = Context.tbSubjectTable.Where(x => x.DayID == 1 && x.SchoolClassID == ClassID).Include(x => x.TeachersAndSubject).ThenInclude(x => x.Subject).Include(x => x.TeachersAndSubject).ThenInclude(x => x.teacher);

            CTVM.ListOfSubSun = Context.tbSubjectTable.Where(x => x.DayID == 2 && x.SchoolClassID == ClassID).Include(x => x.TeachersAndSubject).ThenInclude(x => x.Subject).Include(x => x.TeachersAndSubject).ThenInclude(x => x.teacher);

            CTVM.ListOfSubMon = Context.tbSubjectTable.Where(x => x.DayID == 3 && x.SchoolClassID == ClassID).Include(x => x.TeachersAndSubject).ThenInclude(x => x.Subject).Include(x => x.TeachersAndSubject).ThenInclude(x => x.teacher);

            CTVM.ListOfSubTue = Context.tbSubjectTable.Where(x => x.DayID == 4 && x.SchoolClassID == ClassID).Include(x => x.TeachersAndSubject).ThenInclude(x => x.Subject).Include(x => x.TeachersAndSubject).ThenInclude(x => x.teacher);

            CTVM.ListOfSubWed = Context.tbSubjectTable.Where(x => x.DayID == 5 && x.SchoolClassID == ClassID).Include(x => x.TeachersAndSubject).ThenInclude(x => x.Subject).Include(x => x.TeachersAndSubject).ThenInclude(x => x.teacher);

            CTVM.ListOfSubThr = Context.tbSubjectTable.Where(x => x.DayID == 6 && x.SchoolClassID == ClassID).Include(x => x.TeachersAndSubject).ThenInclude(x => x.Subject).Include(x => x.TeachersAndSubject).ThenInclude(x => x.teacher);

            CTVM.ListOfSubFri = Context.tbSubjectTable.Where(x => x.DayID == 7 && x.SchoolClassID == ClassID).Include(x => x.TeachersAndSubject).ThenInclude(x => x.Subject).Include(x => x.TeachersAndSubject).ThenInclude(x => x.teacher);

            return View(CTVM);
        }




    }
}