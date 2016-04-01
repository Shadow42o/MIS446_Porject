//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using HuskyAir.Models;

//namespace HuskyAir.Controllers
//{
//    public class AccountControllerTest : Controller
//    {
//        // GET: AccountControllerTest
//        public ActionResult Index()
//        {
//            using (OurDbContext db = new OurDbContext())
//            {
//                return View(db.userAccount.ToList());
//            }
//        }

//        public ActionResult Register()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Register(UserAccount account)
//        {
//            if (ModelState.IsValid)
//            {
//                using (OurDbContext db = new OurDbContext())
//                {
//                    db.userAccount.Add(account);
//                    db.SaveChanges();
//                }
//                ModelState.Clear();
//                ViewBag.Message = account.FirstName + " " + account.LastName + " successfully registered.";
//            }
//            return View();
//        }

//        //Login
//        public ActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult  Login(UserAccount user)
//        {
//            using (OurDbContext db = new OurDbContext())
//            {
//                var usr = db.userAccount.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
//                if (usr != null)
//                {
//                    Session["userId"] = usr.UserID.ToString();
//                    Session["Username"] = usr.Username.ToString();
//                    return RedirectToAction("LoggedIn");
//                }
//                else
//                {
//                    ModelState.AddModelError("", "Username or Password is wrong.");
//                }
//            }
//            return View();
//        }

//        public ActionResult LoggedIn()
//        {
//            if (Session["UserId"] != null)
//            {
//                return View();
//            }
//            else
//            {
//                return RedirectToAction("Login");
//            }
//        }
//    }
//}