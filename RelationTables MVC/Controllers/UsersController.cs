using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelationTables_MVC.Models;
using RelationTables_MVC.Models.Repository;
using RelationTables_MVC.Models.Repository.IRepository;


namespace RelationTables_MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly IServiceUser<User> _User;
        private readonly IServiceUserType<Usertype> _UserType;
        public UsersController(IServiceUser<User> user,IServiceUserType<Usertype> userType)
        {
            _User = user;
            _UserType = userType;
        }
        public IActionResult Index()
        {
            return View(_User.List());
        }
        [HttpGet]
        public IActionResult Create()
        {
            SelectList selectList= new SelectList(_UserType.List(), "UserTypeId", "TypeDesc");
            ViewBag.items = selectList;
            return View();
        }

        [HttpPost]
        public IActionResult Create()
        {
           if(ModelState.IsValid)
            {
                _user.Add(user);
                return RedirectToAction("Index");
            }
           return View();
        }
    }
}
