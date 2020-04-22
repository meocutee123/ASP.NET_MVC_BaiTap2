﻿using BaiTap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2.Controllers
{
    public class StudentController : Controller
    {
        // GET: STUDENT/REGISTER1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        //Request
        [HttpPost]
        public ActionResult Register1()
        {
                String ID = Request["ID"];
                String Name = Request["Name"];
                double Marks = Convert.ToDouble(Request["Marks"]);
                ViewData["ID"] = ID;
                ViewData["Name"] = Name;
                ViewData["Marks"] = Marks;
                return View("Index");
        }

        //Actions Argument
        public ActionResult Register2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register2(String ID, String Name, double Marks)
        {
            ViewData["ID"] = ID;
            ViewData["Name"] = Name;
            ViewData["Marks"] = Marks;
            return View("Index");
        }

        //Form Collection
        public ActionResult Register3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register3(FormCollection collection)
        {
            try
            {
                ViewData["ID"] = collection[1];
                ViewData["Name"] = collection[2];
                ViewData["Marks"] = collection[3];
                return View("Index");
            }
            catch
            {
                return View();
            }
        }

        //Model
        public ActionResult Register4()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register4(StudentModel sm)
        {
            if (ModelState.IsValid)
            {
                ViewData["ID"] = sm.ID;
                ViewData["Name"] = sm.Name;
                ViewData["Marks"] = sm.Marks;
                return View("Index");
            }
            else
            {
                return View();
            }
        }
    }
}