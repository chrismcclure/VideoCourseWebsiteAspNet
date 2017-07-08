using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Controllers
{
 
    public class EmployeeController : Controller
    {
        public EmployeeController()
        {

        }

        public ContentResult Name()
        {
            return Content("Chris Rules");
        }
        public string Country()
        {
            return "Chris wants to visit Sweden";
        }
        public string Index()
        {
            return "Hello from Employee";
        }
    }
}
