using PagedList;
using QLDaiLy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace QLDaiLy.Controllers
{
    public class SanPhamController : Controller
    {
        QuanLyDaiLy db = new QuanLyDaiLy();
        // GET: SanPham
        public ActionResult Index(string searchString, string currentFilter, int? page)
        {
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            var sanPham = db.SanPhams.OrderByDescending(n => n.TenSP).ToList();
            return View(sanPham.ToPagedList(pageNumber, pageSize));
        }


        [HttpPost]
        public PartialViewResult Search(string searchString)
        {
            var data = db.SanPhams.Where(n => n.TenSP.Contains(searchString)).ToList();
            var a = data.Count();
            if (a <= 0)
            {
                ViewBag.ThongBao = "Không có kết quả nào được tìm thấy";
                return PartialView(data);
            }
            return PartialView(data);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }
    }
}