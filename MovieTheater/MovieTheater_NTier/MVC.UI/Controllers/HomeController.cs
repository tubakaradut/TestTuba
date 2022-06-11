using COMMON;
using DAL.Entities;
using MVC.UI.VMClasses;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Controllers
{
    public class HomeController : Controller
    {
        AppUserService _arep=new AppUserService();
        MovieService movieService = new MovieService();


        public ActionResult index()
        {

            return View(movieService.GetList());
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AppUserVM appUserVM)
        {
            AppUser user = _arep.GetDefault(x => x.Username == appUserVM.Username && x.Password == appUserVM.Password).FirstOrDefault();

            if (user.Username != null && user.Password != null)
            {

                if (user.Role == Core.Enum.AppUserRole.Admin)
                {
                    if (!user.IsActive)
                    {
                        return AktifKontrol();
                    }
                    Session["admin"] = user;
                    return RedirectToAction("CategoryList", "Category", new { area = "Admin" });
                }
                else if (user.Role == Core.Enum.AppUserRole.Member)
                {
                    if (!user.IsActive)
                    {
                        return AktifKontrol();
                    }
                    Session["member"] = user;
                    return RedirectToAction("index");
                }

                else
                {
                    TempData["error"] = "kullanıcı bilgileri hatalı!";
                    return View(appUserVM);
                }

            }
            return View(appUserVM);
        }



        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(AppUserVM appUserVM)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser();
                appUser.Email = appUserVM.Email;
                appUser.Password = appUserVM.Password;
                appUser.Username = appUserVM.Username;
                appUser.ActivationCode = Guid.NewGuid();
                var result = _arep.Add(appUser);

                TempData["info"] = result;
                //Mailsender
                MailSender.SendEmail(appUserVM.Email, "Üyelik Aktivayon", $"üyeliğinizi aktif hale getirebilmek için linki tıklayın https://localhost:44393/Home/Activation/" + appUser.ActivationCode);
                return RedirectToAction("Pending");


            }
            else
            {
                return View(appUserVM);
            }

        }

        public ActionResult Pending(AppUser user)
        {
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        public ActionResult Activation(Guid id)
        {
            if (id != null)
            {
                AppUser user = _arep.GetDefault(x => x.ActivationCode == id).FirstOrDefault();
                user.IsActive = true;
                _arep.Update(user);
                return RedirectToAction("Login", "Home");
            }
            else
            {
                return RedirectToAction("Register");
            }

        }
        private ActionResult AktifKontrol()
        {
            ViewBag.AktifDegil = "Lutfen hesabınızı aktif hale getiriniz...Mailinizi kontrol ediniz...";
            return View("Login");
        }

    }
}