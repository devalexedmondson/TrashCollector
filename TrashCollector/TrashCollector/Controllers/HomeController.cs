using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole("customer"))
            {
                return View("CustomerPage"/*, new Pick_Up_Options() { Day = "Monday" }*/ );
            }
            else if (User.IsInRole("collector"))
            {
                return View("CollectorPage");
            }else
            {
                return View();
            }

        }
        public ActionResult GetAddressForEachUser()
        {
            var userAddresses = new List<AddressesViewModel>();
            var context = new ApplicationDbContext();
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            
            foreach (var user in userStore.Users)
            {
                var a = new AddressesViewModel
                {
                    Name = user.UserName,
                    Street = "suh"
                };
                userAddresses.Add(a);
            }

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}