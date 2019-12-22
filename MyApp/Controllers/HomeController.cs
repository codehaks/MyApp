using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    public class HomeController : Controller
    {

        [Route("CLInstitutes.aspx")]
        public IActionResult Index(string page)
        {
            return Ok($"routed to ->Home->Index->{page}");
        }

        [Route("TakeMeBack/{page}")]
        public IActionResult TakeMeBack(string page)
        {
            return Redirect("/CLInstitutes.aspx?page="+page);
        }
    }
}