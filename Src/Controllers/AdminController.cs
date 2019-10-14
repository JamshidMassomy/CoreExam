using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("admin/index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}