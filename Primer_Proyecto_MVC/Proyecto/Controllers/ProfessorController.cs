using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        public ActionResult Index()
        {
            return View();
        }

        ProfessorDataEF ProfessorDataEF = new ProfessorDataEF();
        Email Email = new Email();

        public JsonResult Add(Professor professor, Location location, User user)
        {
            Email.SendEmail(professor.Mail, "New user", professor.Name + " " + professor.LastName + ", has been approved." +
                "\nUsername: " + user.Username +
                "\nTemporal password: " + user.Password + "\nGo to the site to make the password change.");
            return Json(ProfessorDataEF.Add(professor, location, user), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update(Professor professor, Location location, User user)
        {
            return Json(ProfessorDataEF.Update(professor, location, user), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(int id)
        {
            var professor = ProfessorDataEF.GetProfessorById(id);

            return Json(professor, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListAllProfessors()
        {
            var professors = ProfessorDataEF.ListAllProfessors();

            return Json(professors, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteProfessor(int id)
        {
            return Json(ProfessorDataEF.DeleteProfessor(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListAcademicDegree()
        {
            var academicDegree = ProfessorDataEF.ListAcademicDegree();

            return Json(academicDegree, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AddSocialNetwork(SocialNetworksProfessor socialNetworksProfessor)
        {
            return Json(ProfessorDataEF.AddSocialNetwork(socialNetworksProfessor), JsonRequestBehavior.AllowGet);
        }

        public JsonResult AddProfessorCourse(ProfessorCourse professorCourse)
        {
            return Json(ProfessorDataEF.AddProfessorCourse(professorCourse), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListSocialNetworksCatalog()
        {
            return Json(ProfessorDataEF.ListSocialNetworksCatalog(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSocialNetworksByIdProfessor(int id)
        {
            return Json(ProfessorDataEF.GetSocialNetworksByIdProfessor(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateImage(Professor professor)
        {
            return Json(ProfessorDataEF.UpdateImage(professor), JsonRequestBehavior.AllowGet);
        }
    }
}