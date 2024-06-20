using E_project.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace E_project.Controllers
{

    
    public class HomeController : Controller
    {
        InsurancePlatformDbContext db = new InsurancePlatformDbContext();
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Loans()
        {
            return View(db.Createloans.ToList());
        }

        //applylaon
        [HttpGet]
        public IActionResult ApplyLoans()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ApplyLoans(AppyLoan apply, IFormFile file, IFormFile cnicPhotoFile)
        {
            var imageName = Path.GetFileName(file.FileName);
            string imagePath = Path.Combine(HttpContext.Request.PathBase.Value, "wwwroot/img/");
            string imagevalue = Path.Combine(imagePath, imageName);
            using (var stream = new FileStream(imagevalue, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            var dbimage = Path.Combine("/img/", imageName);
            apply.Photo = dbimage;
            apply.CnicPhoto = dbimage;
            db.AppyLoans.Add(apply);
            db.SaveChanges();


            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }

       

        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult availpolicy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public IActionResult availpolicy(Holderspolicy addd)
        {
            if (ModelState.IsValid)
            {
                db.Holderspolicies.Add(addd);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }
        public IActionResult Life()
        {
           
            return View(db.LifePolicies.ToList());
        }
        public IActionResult Home()
        {
            return View(db.HomePolicies.ToList());
        }
        public IActionResult Motor()
        {

            return View(db.MotorPolicies.ToList());
        }
        public IActionResult Health()
        {
            return View(db.HealthPolicies.ToList());
        }

        public IActionResult premi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult premi(IFormCollection frm, string Category, my m, string term)
        {
            int n1 = Convert.ToInt32(frm["num1"]);


            if (Category == my.categ.Yearly.ToString())
            {
                int result = ((n1 / 2));

                ViewBag.rs = result;
            }


            else
            {

                int result = ((n1 / 2));

                ViewBag.rs = result;

            }

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User users)
        {
            if (ModelState.IsValid)
            {
                var emails = db.Users.FirstOrDefault(User => User.Email == users.Email);
                if (emails == null)
                {
                    users.Roleid = 1;
                    db.Users.Add(users);
                    db.SaveChanges();
                    return RedirectToAction("Login");


                }
                else
                {
                  
                    ViewBag.error = "email already exists";
                }



            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User lg) 
        {
            ClaimsIdentity identity = null;
            bool isAuthenticated = false;

            var res = db.Users.FirstOrDefault(x => x.Email == lg.Email && x.Password == lg.Password);
            if (res != null)
            {

                if (res.Roleid == 0)
                {

                    //Create the identity for the user
                    identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name,lg.Email),
                    new Claim(ClaimTypes.Sid, res.UserId.ToString()),
                    new Claim(ClaimTypes.Role, "Admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                    isAuthenticated = true;
                }

                if (res.Roleid == 1)
                {
                    //Create the identity for the user
                    identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, lg.Email),
                     new Claim(ClaimTypes.Sid, res.UserId.ToString()),
                    new Claim(ClaimTypes.Role, "User")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                    isAuthenticated = true;
                }






                if (isAuthenticated && res.Roleid == 0)
                {
                    var principal = new ClaimsPrincipal(identity);

                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return RedirectToAction("Index", "admin");
                }




               
                else if (isAuthenticated && res.Roleid == 1)
                {
                    var principal = new ClaimsPrincipal(identity);

                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return RedirectToAction("Index", "Home");
                }
            }
                return View();
        }
       

        //[HttpGet]
        //public IActionResult ApplyLoans(int id)
        //{
        //    var edt = db.Createloans.Find(id);

        //    return View(edt);
        //}
        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }

}
