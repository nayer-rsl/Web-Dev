using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3.Models;
using System.Diagnostics;


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
        //GET : Teacher/Add
        [HttpGet]
        [Route("Teacher/add")]
        public ActionResult Add()
        {
            return View();
        }
        
        // POST : Teacher/Create
        [HttpPost]
        [Route("Teacher/Create")]
        public ActionResult Create(string TeacherFname, string TeacherLname, string EmployeeNumber, DateTime HireDate, decimal Salary)
        {
            Debug.WriteLine("First Name:"+TeacherFname+" Last Name:"+TeacherLname+" Employee Number:"+EmployeeNumber+" Hire Date:"+HireDate+ " Salary:"+Salary);
            //Redirect to the list of theachers

            //Access database
            Teacher NewTeacher = new Teacher();
            NewTeacher.TeacherFname = TeacherFname;
            NewTeacher.TeacherLname = TeacherLname;
            NewTeacher.EmployeeNumber = EmployeeNumber;
            NewTeacher.HireDate = HireDate;
            NewTeacher.Salary = Salary;
            TeacherDataController Controller = new TeacherDataController();

            Controller.AddTeacher(NewTeacher);

            return RedirectToAction("List");
        }
        //GET: DeleteConfirm/{TeacherId}
        public ActionResult DeleteConfirm(int id)
        {
            TeacherDataController Controller = new TeacherDataController();
            Teacher SelectedTeacher = Controller.FindTeacher(id);
            return View(SelectedTeacher);

        }
        public ActionResult Delete(int id)
        {
            TeacherDataController Controller = new TeacherDataController();
            Controller.DeleteTeacher(id);

            return RedirectToAction("List");

        }
    }
}