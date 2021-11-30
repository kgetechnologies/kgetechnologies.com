using kgetechnologies.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kgetechnologies.com.Controllers
{
    public class ContactusController : Controller
    {
        // GET: Contactus
        public ActionResult Index()
        {
            return Json("OK", JsonRequestBehavior.AllowGet);
        }

        // POST: Contactus/Create
        [HttpPost]
     //   [ValidateAntiForgeryToken]
        public ActionResult Create(Enquiry collection)
        {
            try
            {
                return Json(collection, JsonRequestBehavior.AllowGet);

            }
            catch
            {
                return Json("OK", JsonRequestBehavior.AllowGet);
            }
        }
    }
}
