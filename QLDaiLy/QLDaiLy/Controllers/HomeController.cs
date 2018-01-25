using QLDaiLy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDaiLy.Controllers
{
    public class HomeController : Controller
    {
        QuanLyDaiLy db = new QuanLyDaiLy();
        public ActionResult Index()
        {
            var sp = LaySanPham(6);
            return View(sp);
        }

       private List<SanPham> LaySanPham(int count)
       {  
            return db.SanPhams.OrderByDescending(x => x.TenSP).Take(count).ToList();
       }

        public ActionResult LoaiSP()
        {
            var lsp =  from LoaiSP in db.LoaiSPs select LoaiSP;
            return PartialView(lsp);
        }

        public ActionResult SPtheoLoai(int id)
        {
            var sp = from n in db.SanPhams where n.MaSP == id select n;
            return View(sp);
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