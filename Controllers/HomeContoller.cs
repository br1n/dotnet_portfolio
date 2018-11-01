using Microsoft.AspNetCore.Mvc;
using System;
namespace Portfolio
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "This is my Index!";
        }
    
        [HttpGet]
        [Route("projects")]
        public string Projects()
        {
            return "These are my projects";
        }

        [HttpGet]
        [Route("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}