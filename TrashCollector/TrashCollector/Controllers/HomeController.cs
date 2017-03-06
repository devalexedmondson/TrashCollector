using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
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
                return View("CustomerPage");
            }
            else if (User.IsInRole("collector"))
            {
                return View("CollectorPage");
            }else
            {
                return View();
            }
        }


        //public ActionResult GetAddressForEachUser()
        //{
        //    var userAddresses = new List<AddressesViewModel>();
        //    var context = new ApplicationDbContext();
        //    var userStore = new UserStore<ApplicationUser>(context);
        //    var userManager = new UserManager<ApplicationUser>(userStore);

        //    foreach (var user in userStore.Users)
        //    {

        //        List<string> Address = new List<string>();
        //        //foreach(var customerInfo in user.Id.CustomerID)
        //        //{

        //        //}
        //        var a = new AddressesViewModel
        //        {
        //            Name = user.UserName//,
        //            //Street = Address[0],


        //        };
        //        userAddresses.Add(a);
        //    }
        //    return View(userAddresses);
        //}

        public ActionResult UserList()
        {
            var applicationDbContext = HttpContext.GetOwinContext().Get<ApplicationDbContext>();
            var users = from u in applicationDbContext.Users
                        //from ur in u.Roles
                        //join r in ApplicationDbContext.Roles on ur.RoleId equals r.Id
                        select new
                        {
                            u.Id,
                            Name = u.UserName,
                            //Role = /*r.Name,*/ 
                        };

            // users is anonymous type, map it to a Model 
            return View(users);
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