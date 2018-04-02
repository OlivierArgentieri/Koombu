using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;
using supinfo._3asp.koombu.Models;

namespace supinfo._3asp.koombu.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (AccountContext db = new AccountContext())
            {
                return View(db.UserAccounts.ToList());
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAccount account)
        {
            if (ModelState.IsValid)
            {
                using (AccountContext db = new AccountContext())
                {
                    db.UserAccounts.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + " ";
            }
            return View();
        }

        // Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using (AccountContext db = new AccountContext())
            {
                var usr = db.UserAccounts.Where(u => u.Email == user.Email && u.Password == user.Password)
                    .FirstOrDefault();

                if (usr != null)
                {
                    Session["UserID"] = usr.ID.ToString();
                    Session["Email"] = usr.Email;
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Email ou mot de passe incorrect");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserID"]!= null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}