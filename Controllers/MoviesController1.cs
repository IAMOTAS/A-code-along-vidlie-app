using Microsoft.AspNetCore.Mvc;
using A_code_along_vidlie_app.Models;

namespace A_code_along_vidlie_app.Controllers
{
    public class MoviesController1 : Controller
    {
        //GET:Movies/Random
        public IActionResult Random()
        {
            var movie = new Movies()
            {
                Name = "Shrek"
            };
            return View();
        }
    }
}
