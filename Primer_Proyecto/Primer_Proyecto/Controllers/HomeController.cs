using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Primer_Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Primer_Proyecto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
