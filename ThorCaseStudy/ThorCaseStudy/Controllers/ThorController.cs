using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThorCaseStudy.Models;
using System.Linq;




// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThorCaseStudy.Controllers
{
    public class ThorController : Controller
    {
        

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        
		public ActionResult Thor()
		{
			return View();
		}


    }


}
