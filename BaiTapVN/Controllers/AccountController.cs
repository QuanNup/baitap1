using BaiTapVN.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BaiTapVN.Controllers
{
    public class AccountController : Controller
    {



        private static List<RegisterModel> users = new List<RegisterModel>
        {
            new RegisterModel
            {
                Username = "user1",
                Password = "password1",
                Email = "user1@example.com",
                FullName = "User 1",
                DateOfBirth = new DateTime(1990, 1, 1),
                Phone = "123456789",
                Address = "123 ABC Street"
            },
            new RegisterModel
            {
                Username = "user2",
                Password = "password2",
                Email = "user2@example.com",
                FullName = "User 2",
                DateOfBirth = new DateTime(1995, 2, 15),
                Phone = "987654321",
                Address = "456 XYZ Avenue"
            }
        };



        public IActionResult Register(RegisterModel rm)
        {
            if (ModelState.IsValid)
            {
                if (rm.Password != rm.ConfirmPassword)
                {
                    ViewData["PasswordMismatchError"] = "Xác nhận mật khẩu không khớp";
                    return View(rm);
                }
                else
                {
                    users.Add(rm);
                    return RedirectToAction("Index", "Home");
                }

            }
            return View(rm);
        }
        public IActionResult Login(RegisterModel rm)
        {
            if (ModelState.IsValid)
            {
                var user = users.FirstOrDefault(u => u.Username == rm.Username);
                if (user != null)
                {
                    if (user.Password == rm.Password)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewData["LoginError"] = "Mật khẩu không chính xác";
                    }
                }
                else
                {
                    ViewData["LoginError"] = "Tên đăng nhập không tồn tại";
                }
            }
            return View(rm);
        }



    }
}
