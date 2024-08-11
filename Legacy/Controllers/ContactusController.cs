using kgetechnologies.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace kgetechnologies.com.Controllers
{
	public class ContactusController : Controller
	{
		// GET: Contactus
		public ActionResult Index()
		{
			return View(new Enquiry());
		}

		// POST: Contactus/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Index(Enquiry collection)
		{
			if (collection == null)
				return View(new Enquiry() { ErrorMessage = "Request is Not Valid" });

			var errorList = new List<string>();
			if (string.IsNullOrEmpty(collection.Name))
				errorList.Add("Name is missing");
			if (string.IsNullOrEmpty(collection.Subject))
				errorList.Add("Subject is missing");
			if (string.IsNullOrEmpty(collection.Message))
				errorList.Add("Message is missing");
			if (string.IsNullOrEmpty(collection.MobileNumber))
				errorList.Add("Contact Number is missing");
			if (string.IsNullOrEmpty(collection.EmailAddress))
				errorList.Add("Email Address is missing");
			if (collection.EnquiredFor == EnquiredFor.UnKnown)
				errorList.Add("Enquired For is Not Selected");

			if (!errorList.Any())
			{
				//Perform the Email Operation and then Send the Message
				collection.ErrorMessage = "Enquiry Sent Successfully";
				return View(collection);
			}

			return View(collection);
		}
	}	
}
