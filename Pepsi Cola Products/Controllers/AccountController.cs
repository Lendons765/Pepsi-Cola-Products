using Pepsi_Cola_Products.Models;
using Pepsi_Cola_Products.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pepsi_Cola_Products.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Users.Register register)
        {
            DataTable response = new DataTable();
            response = AccountServices.Register(register);

            if(response.Rows.Count > 0)
            {
                ViewBag.Message = "Register Succesful";
            }
            else
            {
                ViewBag.Message = "Register Failed";
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Login(Users.Login login)
        {
            DataTable response = new DataTable();
            response = AccountServices.Login(login);

            if( response.Rows.Count > 0)
            {
                Session["username"] = response.Rows[0]["username"].ToString();
                return RedirectToAction( "Index", "Home");
            }
            else
            {
                ViewBag.Message = "Login Failed! Please try Again";
            }
            return View();

        }

    }
}