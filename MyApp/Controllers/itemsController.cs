using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class itemsController : Controller
    {
        public IActionResult overview()

        {

            var item = new item() { Name = "keyboard" };
            return View(item);
        }
        public IActionResult Edit(int id)
        {
            return Content("id" + id );
        }
    }
}
            

            

        


 

