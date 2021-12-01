using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher/List
        [HttpGet]
        public ActionResult List()
        {
            //Gather info from the db
            TeacherDataController Controller = new TeacherDataController();
            IEnumerable<Teacher> Teachers = Controller.ListTeachers();
            return View(Teachers);
        }
        //GET : Teacher/Show/{teacherid}
        [HttpGet]
        [Route("Teacher/Show/{id}")]
        public ActionResult Show(int id)
        {
            TeacherDataController Controller = new TeacherDataController();
            Teacher NewTeacher = Controller.FindTeacher(id);
            return View(NewTeacher);
        }
    }
}