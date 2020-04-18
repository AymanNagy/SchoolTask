using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Controllers
{
    public class TeachersAndSubjectController : Controller
    {

        private readonly AppDpContext Context;

        public TeachersAndSubjectController(School.Models.AppDpContext context)
        {
            this.Context = context;

        }

        public ViewResult ListOfTeachers()
        {

            return View(Context.tbTeachers);
        }


        public ViewResult ListOfSubjects(int TeacherID)
        {
            Models.ViewModel.TeachersAndSubjectViewModel TSV = new Models.ViewModel.TeachersAndSubjectViewModel();
            TSV.TeatcherID = TeacherID;
            var ListOFTeatchrSubject = Context.tbTeachersAndSubject.Where(x => x.teacher.TeacherID == TeacherID).Include(z => z.Subject);
            TSV.ListOfSubjects = Context.tbSubjects.Where(x=> !ListOFTeatchrSubject.Any(z=>z.Subject.SubjectsID == x.SubjectsID));
            return View(TSV);
        }



      public ViewResult ListOfTeatcherSubjects(int TeacherID)
        {
            var ListOfSub = Context.tbTeachersAndSubject.Where(x => x.TeacherID == TeacherID).Include(x => x.Subject);
            return View(ListOfSub);
        }

        public ActionResult DeleteSubjects(int TeatcherAndSubjectID)
        {
            var SelectedSubject = Context.tbTeachersAndSubject.FirstOrDefault(x => x.TeachersAndSubjectID == TeatcherAndSubjectID);
            Context.tbTeachersAndSubject.Remove(SelectedSubject);
            Context.SaveChanges();
            return RedirectToAction("ListOfTeatcherSubjects", "TeachersAndSubject",new { TeacherID = SelectedSubject.TeacherID });
        }



        public ActionResult AttachSubjectToTeatcher(int TeatcherID , int SubjectID)
        {
            var test = Context.tbTeachersAndSubject.FirstOrDefault(x => x.SubjectsID == SubjectID && x.TeacherID == TeatcherID);
            if (test == null)
            {
                Models.Database.TeachersAndSubject TAS = new Models.Database.TeachersAndSubject();
                TAS.SubjectsID = SubjectID;
                TAS.TeacherID = TeatcherID;
                Context.tbTeachersAndSubject.Add(TAS);
                Context.SaveChanges();
                return RedirectToAction("ListOfSubjects", "TeachersAndSubject", new { TeacherID = TeatcherID });
            }
            return View();

        }
    }
}