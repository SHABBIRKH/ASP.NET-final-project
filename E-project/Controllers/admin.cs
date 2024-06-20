using E_project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace E_project.Controllers
{
    public class admin : Controller
    {
        //conecting your model context file
        InsurancePlatformDbContext db = new InsurancePlatformDbContext();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Loan()
        {
            return View();
        }

        public IActionResult LoanList()
        {
            return View(db.AppyLoans.ToList());
        }

        [HttpGet]
        public IActionResult AddLoan()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddLoan(Createloan loanentry)
        {
            if (ModelState.IsValid)
            {
                db.Createloans.Add(loanentry);
                db.SaveChanges();
            }
            return RedirectToAction("LoanList");
        }

        public IActionResult UpdateLoan(int id)
        {
            var edt = db.AppyLoans.Find(id);

            if (edt == null)
            {
                return NotFound();
            }

            edt.ApprovelStatus = "approve";
            db.AppyLoans.Update(edt);
            db.SaveChanges(true);

            return RedirectToAction("LoanList");
        }

        public IActionResult deleteLoan(int id)
        {
            var edt = db.AppyLoans.Find(id);

            if (edt == null)
            {
                return NotFound();
            }

            edt.ApprovelStatus = "Reject";
            db.AppyLoans.Update(edt);
            db.SaveChanges(true);

            return RedirectToAction("LoanList");

        }



        //life policy section start//

        [HttpGet]
        public IActionResult lifepolicy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult lifepolicy(LifePolicy addlifepolicy)
        {
            if (ModelState.IsValid)
            {
                db.LifePolicies.Add(addlifepolicy);
                db.SaveChanges();
                return RedirectToAction("lifepolicylist");
            }
            return View();

        }

        public IActionResult lifepolicylist()
        {
            return View(db.LifePolicies.ToList());
        }

        public IActionResult deletelifepolicy(int id)
        {
            var xyz = db.LifePolicies.Find(id);
            if (xyz == null)
            {
                return RedirectToAction("lifepolicylist");

            }


            db.LifePolicies.Remove(xyz);
            db.SaveChanges(true);
            return RedirectToAction("lifepolicylist");
        }
        [HttpGet]
        public IActionResult updatelifepolicy(int id)
        {
            var edt = db.Policies.Find(id);

            return View(edt);
        }

        [HttpPost]
        public IActionResult updatelifepolicy(LifePolicy valuess)
        {
            if (ModelState.IsValid)
            {
                db.LifePolicies.Update(valuess);
                db.SaveChanges();

            }
            return RedirectToAction("lifepolicylist");
        }

        //life policy section end

        //health policy section start
        [HttpGet]
        public IActionResult healthpolicy()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult healthpolicy(HealthPolicy addhealthpolicy)
        {
            if (ModelState.IsValid)
            {
                db.HealthPolicies.Add(addhealthpolicy);
                db.SaveChanges();
                return RedirectToAction("healthpolicylist");
            }
            return View();
           
        }

        public IActionResult healthpolicylist()
        {
            return View(db.HealthPolicies.ToList());
        }

        public IActionResult deletehealthpolicy(int id)
        {
            var xyz = db.HealthPolicies.Find(id);
            if (xyz == null)
            {
                return RedirectToAction("healthpolicylist");

            }


            db.HealthPolicies.Remove(xyz);
            db.SaveChanges(true);
            return RedirectToAction("Healthpolicylist");
        }
        [HttpGet]
        public IActionResult updatehealthpolicy(int id)
        {
            var edt = db.Policies.Find(id);

            return View(edt);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult updatehealthpolicy(HealthPolicy valuess)
        {
            if (ModelState.IsValid)
            {
                db.HealthPolicies.Update(valuess);
                db.SaveChanges();
                return RedirectToAction("healthpolicylist");

            }
            return View();
        }
        //health policy section end

        //homepolicy section start
        [HttpGet]
        public IActionResult homepolicy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult homepolicy(HomePolicy addhomepolicy)
        {
            if (ModelState.IsValid)
            {
                db.HomePolicies.Add(addhomepolicy);
                db.SaveChanges();
                return RedirectToAction("homepolicylist");
            }
            return View();
        }

        public IActionResult homepolicylist()
        {
            return View(db.HomePolicies.ToList());
        }

        public IActionResult motorpolicy()
        {
            return View();
        }

        public IActionResult deletehomepolicy(int id)
        {

            var xyz = db.HomePolicies.Find(id);
            if (xyz == null)
            {
                return RedirectToAction("homepolicylist");

            }


            db.HomePolicies.Remove(xyz);
            db.SaveChanges(true);
            return RedirectToAction("homepolicylist");
        }
        [HttpGet]
        public IActionResult updatehomepolicy(int id)
        {
            var edt = db.HomePolicies.Find(id);

            return View(edt);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult updatehomepolicy(HomePolicy valuess)
        {
            if (ModelState.IsValid)
            {
                db.HomePolicies.Update(valuess);
                db.SaveChanges();
                

            }
            return RedirectToAction("homepolicylist");
        }
        //home policy section end

        

       

        public IActionResult UserList()
        {
            return View(db.Users.ToList());
        }
        public IActionResult PolicyHoldersList()
        {
            return View(db.Holderspolicies.ToList());
        }



        [HttpGet]
        public IActionResult moterpolicy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult moterpolicy(MotorPolicy addmoterpolicy)
        {
            if (ModelState.IsValid)
            {
                db.MotorPolicies.Add(addmoterpolicy);
                db.SaveChanges();
                
            }
            return RedirectToAction("moterlist");

        }

        public IActionResult moterlist()
        {
            return View(db.MotorPolicies.ToList());
        }

        public IActionResult deletemotorpolicy(int id)
        {
            var xyz = db.MotorPolicies.Find(id);
            if (xyz == null)
            {
                return RedirectToAction("moterlist");

            }
            db.MotorPolicies.Remove(xyz);
            db.SaveChanges(true);
            return RedirectToAction("moterlist");
        }

        [HttpGet]
        public IActionResult updatemotorpolicy(int id)
        {
            var edt = db.MotorPolicies.Find(id);

            return View(edt);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult updatemotorpolicy(MotorPolicy valuess)
        {
            if (ModelState.IsValid)
            {
                db.MotorPolicies.Update(valuess);
                db.SaveChanges();

            }
            return RedirectToAction("moterlist");
        }

        //public IActionResult deletelifepolicy(int id)
        //{
        //    var xyz = db.LifePolicies.Find(id);
        //    if (xyz == null)
        //    {
        //        return RedirectToAction("lifepolicylist");

        //    }


        //    db.LifePolicies.Remove(xyz);
        //    db.SaveChanges(true);
        //    return RedirectToAction("lifepolicylist");
        //}
        //[HttpGet]
        //public IActionResult updatelifepolicy(int id)
        //{
        //    var edt = db.Policies.Find(id);

        //    return View(edt);
        //}

        //[HttpPost]
        //public IActionResult updatelifepolicy(LifePolicy valuess)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.LifePolicies.Update(valuess);
        //        db.SaveChanges();

        //    }
        //    return RedirectToAction("lifepolicylist");
        //}

        //life policy section end
        public IActionResult approvepolicy()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult approvepolicy(string email, string msg)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("bhicorni@gmail.com", "vles ndzq codd mkiv");

            MailMessage mesage = new MailMessage(email, email);
            mesage.Subject = "220f3";
            mesage.Body = "dear user" + msg;

            client.Send(mesage);

            ViewBag.returnmsg = "approval email has been sent!";
            return View();
        }

    }

}