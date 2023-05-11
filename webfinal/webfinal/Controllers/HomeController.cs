using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webfinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Kiểm tra Session để đảm bảo người dùng đã đăng nhập
            if (Session["Username"] != null)
            {
                // Người dùng đã đăng nhập, hiển thị trang Home
                return View();
            }
            else
            {
                // Người dùng chưa đăng nhập, chuyển hướng đến trang đăng nhập
                return RedirectToAction("Login", "Account");
            }
        }

      
        public ActionResult test()
        {
            ViewBag.Message = "TEST web";
            return View();
        }

     



        public ActionResult Logout()
        {
            // Xóa thông tin đăng nhập từ Session
            Session["Username"] = null;

            // Chuyển hướng đến trang đăng nhập
            return RedirectToAction("Login", "Account");
        }

       
    }
}