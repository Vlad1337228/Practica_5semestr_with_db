using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj_last2.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Proj()
        {
            return View();
        }
    }
}
