using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVC.Controllers
{
    public class MotoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}