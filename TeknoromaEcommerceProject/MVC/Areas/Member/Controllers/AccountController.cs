using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC.Areas.Member.Models;

namespace MVC.Areas.Member.Controllers
{
    [Area("Member")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(AppUserRegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }
            AppUser user = new AppUser()
            {
                UserName = registerVM.UserName,
                Email = registerVM.Email
            };
            var result = await userManager.CreateAsync(user, registerVM.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account", new { Area = "Member" });
            }
                        
            return View(registerVM);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AppUserLoginVM loginVM)
        {
            if (ModelState.IsValid)
            {

                AppUser user = await userManager.FindByNameAsync(loginVM.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    var result = await signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return Redirect("/Home/Index");
                    }
                }

            }
            return View();
        }
        public async Task<IActionResult> Profile()
        {
            AppUser user = new AppUser();
            if (signInManager.IsSignedIn(User))
            {
                user = await userManager.GetUserAsync(User);
                AppUserVM appUserVM = new AppUserVM();
                appUserVM.Email = user.Email;
                appUserVM.UserName = user.UserName;
                return View(appUserVM);
            }
            else
            {
                return RedirectToAction("Login", "Account", new { Area = "Member" });
            }
        }
    }
}