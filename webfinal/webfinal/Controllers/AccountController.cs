using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webfinal.Models;
using static webfinal.Controllers.HomeController;

namespace webfinal.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

        public ActionResult Login()
        {
            if (Session["Username"] != null)
            {
                // Người dùng đã đăng nhập, chuyển hướng đến trang Home hoặc trang chính của ứng dụng
                return RedirectToAction("Index", "Home");
            }
            // Hiển thị giao diện đăng nhập
            return View();
        }
        public class LoginViewModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

         [HttpPost]
       // [Authorize]
        public ActionResult Login(LoginViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                // Kiểm tra Session để đảm bảo người dùng đã đăng nhập

                // Xử lý đăng nhập, kiểm tra thông tin đăng nhập hợp lệ
                if (IsValidUser(model.Username, model.Password))
                {
                    // Đăng nhập thành công, thực hiện các thao tác cần thiết
                    // Ví dụ: lưu thông tin đăng nhập vào session
                    Session["Username"] = model.Username;
                    // Chuyển hướng đến trang home
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Thông tin đăng nhập không hợp lệ.");
                }
            }

            // Nếu đăng nhập không thành công, hiển thị lại giao diện đăng nhập với thông báo lỗi
            return View(model);
        }

      

        private bool IsValidUser(string username, string password)
        {
            AgentModel agentModel = new AgentModel();
            return agentModel.IsValidUser(username, password);
        }


    }
}