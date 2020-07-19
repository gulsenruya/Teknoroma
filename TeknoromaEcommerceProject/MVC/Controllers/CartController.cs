using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using BLL.Service;
using DAL.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC.CustomHelpers;
using MVC.Models.CartModel;
using MVC.Models.ViewModel;

namespace MVC.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService productService;
        private readonly IOrderService orderService;
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;
        private readonly IUserAdressService userAdressService;
        private readonly IShipperService shipperService;

        public CartController(IProductService productService,IOrderService orderService,SignInManager<AppUser> signInManager,UserManager<AppUser> userManager,IUserAdressService userAdressService,IShipperService shipperService)
        {
            this.productService = productService;
            this.orderService = orderService;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.userAdressService = userAdressService;
            this.shipperService = shipperService;
        }
        public IActionResult Index()
        {
            if (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart") != null)
            {
                Cart cartSession = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart");
                return View(cartSession.MyCart);
            }
            else
            {
                //ViewBag.ErrorCart = "Sepetinizde ürün bulunmamaktadır lütfe ürün ekleyiniz !";
                //TempData nesnesini eğer ki bir daha kullanmak istersek bir sonraki redirek ettiğimiz actionda herhangi bir işleme mağruz kalmadan kullanabiliriz. Fakat ViewBag ve ViewData nesnelerine ulaşamayız. 
                TempData["ErrorCart"] = "Sepetinizde ürün bulunmamaktadır lütfen ürün ekleyiniz!";
                return View();
            }

        }
        public IActionResult AddToCart(Guid id)
        {
            Cart cartSession = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart") == null ? new Cart() : SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart");
            var product = productService.GetById(id);
            CartItem cartItem = new CartItem();
            cartItem.ID = product.ID;
            cartItem.Name = product.ProductName;
            cartItem.ImagePath = product.ImagePath;
            cartItem.Price = product.Price;            
            cartSession.AddItem(cartItem);
            SessionHelper.SetProductJson(HttpContext.Session, "cart", cartSession);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid id)
        {
          
            Cart cartSession = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart");
            var product = productService.GetById(id);
            if (product != null)
            {
                foreach (var item in cartSession._cart)
                {
                    if (item.Key== product.ID)
                    {
                        cartSession._cart.Remove(item.Key);
                        SessionHelper.SetProductJson(HttpContext.Session, "cart", cartSession);
                        ViewBag.Success= $"{product.ProductName}  ürün sepetinizden çıkarıldı";
                        return RedirectToAction("Index","Cart");
                    }
                 
                }
            }
            else
            {
                ViewBag.Error = $"{product.ProductName} ürün sepetinizden çıkarılırken bir hata oluştu!";
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> CompleteCart(Guid id)
        {
            Cart cartSession=SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart");
            Order order = new Order();
            if (signInManager.IsSignedIn(User))
            {
                var user = await userManager.GetUserAsync(User);
                var userAdress = userAdressService.GetAdress(user.Id);
                order.AppUser = user;
                order.Confirmed = false;
                order.ShipperId = cartSession.ShipperId;
                order.AdressId = userAdress.ID;
            }
            else
            {
                return Redirect("/Member/Account/Login");
            }
            if (cartSession != null) {
                foreach (var item in cartSession.MyCart)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    var product = productService.GetById(item.ID);
                    orderDetail.Quantity = item.Quantity;
                    orderDetail.Products = product;
                    orderDetail.UnitPrice = item.Price;
                    order.OrderDetails.Add(orderDetail);
                }
            }
            
            Random rnd = new Random();
            int rndMasterId = rnd.Next(000000001, 999999999);
            order.MasterId = rndMasterId;            
            orderService.Add(order);
            
            foreach (var item in cartSession.MyCart)
            {
                var product = productService.GetById(item.ID);
                Delete(product.ID);
                

            }
            return View(order);

        }
        public IActionResult DeliveryAdd()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> DeliveryAdd(UserAdress userAdress)
        {
            AppUser appUser = await userManager.GetUserAsync(User);
            userAdress.AppUserId = appUser.Id;
            userAdressService.Add(userAdress);
            //var name=userAdress.AdressName;
            return RedirectToAction("Shipment");

        }
        public async Task<IActionResult> Delivery()
        {
            AddressVM addressVM = new AddressVM();
            if (signInManager.IsSignedIn(User))
            {
                AppUser appUser = await userManager.GetUserAsync(User);
                if (appUser != null)
                {
                    //address                    
                    var userAdress = userAdressService.GetByIdUser(appUser.Id);                    
                    List<UserAdress> userAdresList = new List<UserAdress>();
                    foreach (var item in userAdress)
                    {
                        userAdresList.Add(item);
                    }
                    addressVM.UserAdresses = userAdresList;
                   
                }
            }
            Cart cartSession = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart");
            addressVM.cartItems = cartSession.MyCart;
            return View(addressVM);
        }
        public IActionResult AdressSelect(Guid id)
        {
            if (id != null)
            {
                var adress = userAdressService.SetAdress(id);
            }
            return Json(new { success = true, Message ="Adres seçildi " });
        }
        public IActionResult SignedIn()
        {
            if (signInManager.IsSignedIn(User))
            {

                return Redirect("/Cart/Delivery");
            }
            else
            {
                return Redirect("/Member/Account/Login");
            }
            
        }
        public async Task<IActionResult> Shipment(Guid id)
        {
            AddressVM addressVM = new AddressVM();
            if (signInManager.IsSignedIn(User))
            {
                AppUser appUser = await userManager.GetUserAsync(User);
                if (appUser != null)
                {
                    //shipment
                    var shipment = shipperService.GetActive();
                    List<Shipper> shipperList = new List<Shipper>();
                    foreach (var item in shipment)
                    {
                        shipperList.Add(item);
                    }
                    addressVM.Shippers = shipperList;
                }
            }
                    
            return View(addressVM);

        }
        public IActionResult ShipmentSelect(Guid id)
        {

            var shipment = shipperService.GetById(id);
            Cart cart = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart");
            cart.ShipperId = shipment.ID;
            SessionHelper.SetProductJson(HttpContext.Session, "cart", cart);
            return Json(new { success = true });


        }

    }

}
