using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment3.Models;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Web.Http.Cors;

namespace Assignment3.Controllers
{
    public class TeacherDataController : ApiController
    {
        //access the database
        private SchoolDbContext School = new SchoolDbContext();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/TeacherData/ListTeachers")]
        public List<Teacher> ListTeachers()
        {
            //Create an instance of a connection
            MySqlConnection Conn = School.AccessDatabase();

            //open the connection between the web server and database
            Conn.Open();

            //new command for the databse
            MySqlCommand cmd = Conn.CreateCommand();

            //SQL QUERY
            cmd.CommandText = "select * from teachers";

            //Gather resultset of Query into a variable
            MySqlDataReader ResultSet = cmd.ExecuteReader();

            //Create an empty list of Teachers
            List<Teacher> Teachers = new List<Teacher> { };

            //Loop through each row of the resullt set
            while (ResultSet.Read())
            {
                //Access information from db
                int TeacherId = (int)ResultSet["teacherid"];
                string TeacherFname = ResultSet["teacherfname"].ToString();
                string TeacherLname = ResultSet["teacherlname"].ToString();
                string EmployeeNumber = ResultSet["employeenumber"].ToString();
                DateTime HireDate = (DateTime)ResultSet["hiredate"];
                decimal Salary = (decimal)ResultSet["salary"];

                Teacher NewTeacher = new Teacher();
                NewTeacher.TeacherId = TeacherId;
                NewTeacher.TeacherFname = TeacherFname;
                NewTeacher.TeacherLname = TeacherLname;
                NewTeacher.EmployeeNumber = EmployeeNumber;
                NewTeacher.HireDate = HireDate;
                NewTeacher.Salary = Salary;

                Teachers.Add(NewTeacher);

            }

            //Close the connection between MySql database and the Webserver
            Conn.Close();

            //Return the list of teachers
            return Teachers;

        }
        
        /// <summary>
        /// Find a Teacher in the database with the given ID
        /// </summary>
        /// <param name="teacherid">teacher Id</param>
        /// <returns>a Teacher object</returns>
        [HttpGet]
        [Route("api/TeacherData/FindTeacher/{TeacherId}")]
        public Teacher FindTeacher(int TeacherId)
        { 
            Teacher NewTeacher = new Teacher();

            //Create an instance of a connection
            MySqlConnection Conn = School.AccessDatabase();

            //open the connection between the web server and database
            Conn.Open();

            //new command for the databse
            MySqlCommand cmd = Conn.CreateCommand();

            //SQL QUERY
            cmd.CommandText = "select * from teachers where teacherid =" +TeacherId;

            //Gather resultset of Query into a variable
            MySqlDataReader ResultSet = cmd.ExecuteReader();

            //Create an empty list of Teachers
            Teacher SelectedTeacher = new Teacher();

            //Loop through each row of the resullt set
            while (ResultSet.Read())
            {
                //Access information from db
                int Id = (int)ResultSet["teacherid"];
                string TeacherFname = ResultSet["teacherfname"].ToString();
                string TeacherLname = ResultSet["teacherlname"].ToString();
                string EmployeeNumber = ResultSet["employeenumber"].ToString();
                DateTime HireDate = (DateTime)ResultSet["hiredate"];
                decimal Salary = (decimal)ResultSet["salary"];

                SelectedTeacher.TeacherId = Id;
                SelectedTeacher.TeacherFname = TeacherFname;
                SelectedTeacher.TeacherLname = TeacherLname;
                SelectedTeacher.EmployeeNumber = EmployeeNumber;
                SelectedTeacher.HireDate = HireDate;
                SelectedTeacher.Salary = Salary;

            }

            //Close the connection between the database and the Webserver
            Conn.Close();

            //Return selected teacher
            return SelectedTeacher;

        }
        /// <summary>
        /// Adds a new Teacher to the database
        /// </summary>
        /// <param name="NewTeacher">Teacher Object</param>
        
        public void AddTeacher(Teacher NewTeacher)
        {
            //Create an instance of a connection
            MySqlConnection Conn = School.AccessDatabase();
            //open the connection between the web server and database
            Conn.Open();

            string query = "insert into teachers (teacherfname,teacherlname,employeenumber,hiredate,salary) values (@TeacherFname,@TeacherLname,@EmployeeNumber,@HireDate,@Salary)";            //new command for the databse
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@TeacherFname", NewTeacher.TeacherFname);
            cmd.Parameters.AddWithValue("@TeacherLname", NewTeacher.TeacherLname);
            cmd.Parameters.AddWithValue("@EmployeeNumber", NewTeacher.EmployeeNumber);
            cmd.Parameters.AddWithValue("@HireDate", NewTeacher.HireDate);
            cmd.Parameters.AddWithValue("@Salary", NewTeacher.Salary);

            //DML operations
            cmd.ExecuteNonQuery();
            //Close connection
            Conn.Close();


        }

        [HttpPost]
        public void DeleteTeacher(int id)
        {
            MySqlConnection Conn = School.AccessDatabase();
            Conn.Open();
            string query = "Delete from teachers where teacherid=@id";
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            Conn.Close();

        }
        /// <summary>
        /// Updates Teacher data given the new information
        /// </summary>
        /// <param name="SelectedTeacher">Teacher information</param>
        /// <returns>nothing</returns>
        public void UpdateTeacher(Teacher SelectedTeacher)
        {
            MySqlConnection Conn = School.AccessDatabase();
            Conn.Open();

            //sql command
            string query = "update teachers set teacherfname=@TeacherFname, teacherlname=@TeacherLname, employeenumber=@EmployeeNumber, hiredate=@HireDate, salary=@Salary where teacherid=@id";
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@TeacherFname", SelectedTeacher.TeacherFname);
            cmd.Parameters.AddWithValue("@TeacherLname", SelectedTeacher.TeacherLname);
            cmd.Parameters.AddWithValue("@EmployeeNumber", SelectedTeacher.EmployeeNumber);
            cmd.Parameters.AddWithValue("@HireDate", SelectedTeacher.HireDate);
            cmd.Parameters.AddWithValue("@Salary", SelectedTeacher.Salary);
            cmd.Parameters.AddWithValue("@id", SelectedTeacher.TeacherId);


            //DML operations
            cmd.ExecuteNonQuery();
            //Close connection
            Conn.Close();

        }

    }
}
