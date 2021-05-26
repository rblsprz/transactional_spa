using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.Models;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace Proyecto.Controllers
{
    public class StudentController : Controller
    {
        Computer Computer = new Computer();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        StudentDataEF StudentDataEF = new StudentDataEF();
        Email Email = new Email();

        public JsonResult Add(Student student, Location location, User user)
        {
            Email.SendEmail(student.Mail, "New User", student.StudentName + " " + student.LastName +
              ", has been approved! Welcome to the Business Computing major from the University of Costa Rica (UCR) ");
            return Json(StudentDataEF.Add(student, location, user), JsonRequestBehavior.AllowGet);
        }

       

        public JsonResult Update(Student student, Location location, User user)
        {
            return Json(StudentDataEF.Update(student, location, user), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(int id)
        {
            var student = StudentDataEF.GetStudentById(id);

            return Json(student, JsonRequestBehavior.AllowGet);
        }

    public JsonResult ListAllStudents()
        {
            var students = StudentDataEF.ListAllStudents();

            return Json(students, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListStudentApproval()
        {
            var students = StudentDataEF.ListStudentApproval();

            return Json(students, JsonRequestBehavior.AllowGet);
        }

        public JsonResult StudentApproval(int id)
        {
            var student = StudentDataEF.GetStudentById(id);
            Email.SendEmail(student.Mail, "Status update", "The student " + student.StudentName + " " + student.LastName + ", has been approved.");
            return Json(StudentDataEF.UpdateStudentStatus(id, "Approve"), JsonRequestBehavior.AllowGet);
        }

        public JsonResult StudentDeny(int id)
        {
            var student = StudentDataEF.GetStudentById(id);
            Email.SendEmail(student.Mail, "Status update", "The student " + student.StudentName + " " + student.LastName + ", has been approved rejected.");
            return Json(StudentDataEF.UpdateStudentStatus(id, "Rejected"), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteStudent(int id)
        {
            return Json(StudentDataEF.DeleteStudent(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListStudents()
        {
            var students = StudentDataEF.ListStudents();

            return Json(students, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AddSocialNetwork(SocialNetworksStudent socialNetworksStudent)
        {
            return Json(StudentDataEF.AddSocialNetwork(socialNetworksStudent), JsonRequestBehavior.AllowGet);
        }

        public JsonResult AddStudentCourse(StudentCourse studentCourse)
        {
            return Json(StudentDataEF.AddStudentCourse(studentCourse), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListSocialNetworksCatalog()
        {
            var socialNetworks = StudentDataEF.ListSocialNetworksCatalog();
            return Json(socialNetworks, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSocialNetworksByIdStudent(int id)
        {
            return Json(StudentDataEF.GetSocialNetworksByIdStudent(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateImage(Student student)
        {
            return Json(StudentDataEF.UpdateImage(student), JsonRequestBehavior.AllowGet);
        }

        public void emailAppointment(String email)
        {
            Email.SendEmail(email, "New appointment date", "You have a new appointment from a student.");
        }
    }
}