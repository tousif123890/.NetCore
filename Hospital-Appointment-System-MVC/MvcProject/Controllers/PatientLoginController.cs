using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class PatientLoginController : Controller
    {
        // GET: PatientLogin
        DBModels db = new DBModels();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorise(PATIENT patient)
        {
            using (DBModels db = new DBModels())
            {
                var patientDetail = db.PATIENTs.Where(x => x.patientName == patient.patientName && x.patientPassword == patient.patientPassword).FirstOrDefault();
                if (patientDetail == null)
                {

                    return View("Index", patient);
                }
                else
                {
                    return RedirectToAction("Index", "PatientHome");
                }
            }
        }
        [HttpGet]
        public ActionResult RegisterPatient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterPatient(PATIENT d1)
        {
            db.PATIENTs.Add(d1);
            db.SaveChanges();
            return View();
        }




        [HttpPost]
        public ActionResult Logout()
        {
            return RedirectToAction("Index", "PatientLogin");
        }
    }
}