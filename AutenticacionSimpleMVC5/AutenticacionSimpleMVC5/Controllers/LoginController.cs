using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutenticacionSimpleMVC5.Models;

namespace AutenticacionSimpleMVC5.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Usuario model)
        {
            var esta = HttpContext.User.Identity;
            if (model.Login == model.Password)
            {
                // 
                var iden = new GenericIdentity(model.Login); // guarda el usuario
                var prin = new GenericPrincipal(iden,new [] {"usuario"}); // USUARIO + ROLES
                //prin.IsInRole() // pregunta un ROL

                HttpContext.User = prin;    // User: usuario autenticado y es de tipo Principal
                                            //HttpContext.User.Identity.is

                Thread.CurrentPrincipal = prin;
                FormsAuthentication.SetAuthCookie(model.Login,false); // escribe la cookie y con false no persiste la cookie ES REmemberMe
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("err","Autenticacion incorrecta");
            return View(model); 
        }
    }
}