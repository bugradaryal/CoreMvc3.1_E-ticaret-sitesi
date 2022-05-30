using System.Collections.Generic;
using System.Threading.Tasks;
using eticaretsitesi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eticaretsitesi.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public UserController(UserManager<User> userMngr,
            RoleManager<IdentityRole> roleMngr)
        {
            this.userManager = userMngr;
            this.roleManager = roleMngr;
        }
        public async Task<IActionResult> Index()
        {
            var users = new List<User>();
            foreach (var user in this.userManager.Users)
            {
                user.RoleNames = await this.userManager.GetRolesAsync(user);
                users.Add(user);
            }

            var model = new UserViewModel {
                Users = users,
                Roles = this.roleManager.Roles
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);
            if (user != null)
            {
                var result = await this.userManager.DeleteAsync(user);
                if (!result.Succeeded) // if failed
                {
                    var errorMessage = "";
                    foreach (var error in result.Errors)
                    {
                        errorMessage += error.Description + " | ";
                    }

                    TempData["message"] = errorMessage;
                }
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User {UserName = model.Username};
                var result = await this.userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddToAdmin(string id)
        {
            var adminRole = await this.roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                TempData["message"] = "Yönetici rolü mevcut değil. "
                                      + "Yönetici rolü oluşturmak için'Yönetici Rolü Oluştur' düğmesine tıklayın.";
            }
            else
            {
                var user = await this.userManager.FindByIdAsync(id);
                await this.userManager.AddToRoleAsync(user, adminRole.Name);
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> RemoveFromAdmin(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);
            var result = await this.userManager.RemoveFromRoleAsync(user, "Admin");
            if (result.Succeeded)
            {
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await this.roleManager.FindByIdAsync(id);
            var result = await this.roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> CreateAdminRole()
        {
            var result = await this.roleManager.CreateAsync(new IdentityRole("Admin"));
            if (result.Succeeded)
            {
            }

            return RedirectToAction("Index");
        }
    }
}