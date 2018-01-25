using QLDaiLy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace QLDaiLy.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        QuanLyDaiLy db = new QuanLyDaiLy();
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = db.NhanViens.FirstOrDefault(n => n.Email == model.Username && n.MatKhau == model.Password);
                if (new QLDaiLyMembershipProvider().ValidateUser(model.Username, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                    if (!String.IsNullOrEmpty(returnUrl))
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        if (user != null)
                        {
                            Session["user"] = user.MaNV;
                            SESSION.ID_USER = user.MaNV;
                            return RedirectToAction("Dashboard", "Home");
                        }
                        else
                        {
                            Session["user"] = 1;
                            SESSION.ID_USER = 0;
                            return RedirectToAction("Dashboard", "Home");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Tài khoản hoặc mật khẩu không đúng");
                }
            }
            return View(model);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session["user"] = null;
            HttpContext.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
            Session.Clear();
            System.Web.HttpContext.Current.Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}