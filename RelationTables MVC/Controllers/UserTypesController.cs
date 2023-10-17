using Microsoft.AspNetCore.Mvc;

namespace RelationTables_MVC.Controllers
{
    public class UserTypesController : Controller
    {
        public UserTypesController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
