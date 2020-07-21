using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using BLL.Service;
using DAL.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC.Areas.ManagerPanel.Models;
using MVC.Areas.Member.Models;
using AppUserVM = MVC.Areas.Member.Models.AppUserVM;

namespace MVC.Areas.Member.Controllers
{
    [Area("Member")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IUserAdressService  userAdressService;
        private readonly IOrderService orderService;
        private readonly IProductService productService;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,IUserAdressService userAdressService,IOrderService orderService,IProductService productService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userAdressService = userAdressService;
            this.orderService = orderService;
            this.productService = productService;
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
                var userAdress = userAdressService.GetByIdUser(user.Id);
                AppUserVM appUserVM = new AppUserVM();
                
                var userOrders= orderService.GetByIdUser(user.Id);
                
                List<Order> orders = new List<Order>();
                
                foreach (var item in userOrders)
                {
                    orders.Add(item);

                }
                
                appUserVM.Orders = orders;
                appUserVM.Email = user.Email;
                appUserVM.UserName = user.UserName;
                List<UserAdress> userAdresList = new List<UserAdress>();
                foreach (var item in userAdress)
                {
                    userAdresList.Add(item);
                }
                appUserVM.UserAdresses = userAdresList;
                return View(appUserVM);
            }
            else
            {
                return RedirectToAction("Login", "Account", new { Area = "Member" });
            }
        }
        public async Task<IActionResult> Details(Guid id)
        {
            AppUser user = new AppUser();
            if (signInManager.IsSignedIn(User))
            {
                user = await userManager.GetUserAsync(User);
                AppUserVM appUserVM = new AppUserVM();
                appUserVM.Orders = orderService.GetByIdUser(user.Id);
                appUserVM.OrderDetails = orderService.GetOrderDetails(id);
                foreach (var item in appUserVM.OrderDetails)
                {
                    var products = productService.GetById(item.ProductId);
                    item.Products = products;
                } 
                return View(appUserVM);
            }
            else
            {
                return RedirectToAction("Login", "Account", new { Area = "Member" });
            }
           
        }
    }
}