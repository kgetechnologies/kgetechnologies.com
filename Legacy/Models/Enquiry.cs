using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace kgetechnologies.com.Models
{
	public class Enquiry
	{
		public string Name { get; set; }
		public string EmailAddress { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
		public string MobileNumber { get; set; }
		public EnquiredFor EnquiredFor { get; set; }
		public string AntiForgeryToken { get; set; }
		public string ErrorMessage { get; set; }
	}

	public enum EnquiredFor
	{
		[Display(Description ="Choose your Option")]
		UnKnown = 0,
		[Display(Description = "Internship")]
		Internship = 10,
		[Display(Description = "Software Work")]
		Development = 20,
	}
}