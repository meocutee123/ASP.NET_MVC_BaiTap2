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
        // Registration action
        public ActionResult Registration()
        {
            return View();
        }
        // Registration post action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(StudentModel sm)
        {
            if (ModelState.IsValid)
            {

                using (StudentInformationDataBaseEntities db = new StudentInformationDataBaseEntities())
                {
                    db.Students.Add(sm);
                    db.SaveChanges();

                }
            }
            return View(sm);
        }

    }
}