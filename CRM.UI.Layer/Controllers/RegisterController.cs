using CRM.Entity.Layer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRM.UI.Layer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUser appUser)
        {
            var result = await _userManager.CreateAsync(appUser, appUser.PasswordHash);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "UserList");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }

        

    }
}
