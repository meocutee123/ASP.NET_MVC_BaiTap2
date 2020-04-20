using BaiTap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Registration(int id = 0)
        {
            StudentTable sm = new StudentTable( );
            return View(sm);
        }
        [HttpGet]
        public ActionResult Registration(StudentTable sdModel)
        {
            using (StudentDatabaseEntities sdDatabase = new StudentDatabaseEntities())
            {
                sdDatabase.StudentTables.Add(sdModel);
                sdDatabase.SaveChanges();
            }
            return View();
        }
    }
}