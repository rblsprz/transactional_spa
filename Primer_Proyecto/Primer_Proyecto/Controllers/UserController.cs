using Primer_Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Primer_Proyecto.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        UserDataEF userDataEF = new UserDataEF();

        public JsonResult ListAllUsers()
        {
            return Json(userDataEF.ListAllUsers(), JsonRequestBehavior.AllowGet);
        }
    }
}
