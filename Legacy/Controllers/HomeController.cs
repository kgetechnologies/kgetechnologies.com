using kgetechnologies.com.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kgetechnologies.com.Controllers
{
	internal class Helper
	{
		public static string AbsoluteUri
		{
			get
			{
				return HttpContext.Current?.Request?.Url?.AbsoluteUri ?? string.Empty;
			}
		}
	}
	public class HomeController : Controller
	{
		public ActionResult Index(string id = "")
		{

			if (string.IsNullOrEmpty(id) || !id.Contains("-internship"))    //!id.Contains("-internship-in-"))
			{
				var _locationLink = InternshipAreas.Select(f => LocationLinks("India", f.Trim())).ToList();

				var response1 = new InternshipResponse()
				{
					City = "India",
					Internship = "Software",
					LocationLinks = string.Join(" ", _locationLink),
					ImageFile = "logo.jpeg",
					InternshipWihHypen = $"https://cdn.kgetechnologies.com/images/Internship/logo.jpeg",
					AbsoluteUri = "http://www.kgetechnologies.com/software-internship-in-India"
				};
				return View(response1);
			}

			if (!id.Contains("-internship-in-") && id.Contains("-internship"))
			{
				id = id.Replace("-internship", "-internship-in-kge-technologies");
			}


			var split = id.Split(new string[] { "-internship-in-" }, StringSplitOptions.None);

			var internship = split[0];
			var location = string.Join(" ", split.Skip(1));

			internship = internship.Replace('-', ' ');
			TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
			var title = textInfo.ToTitleCase(internship);
			location = location.Replace('-', ' ');
			location = textInfo.ToTitleCase(location);

			var LocationLink = InternshipAreas.Select(f => LocationLinks(location, f.Trim())).ToList();

			var ImageFile = (InternshipAreas.FirstOrDefault(f => f.ToLower().Equals(title.ToLower()) || f.ToLower().Contains(title.ToLower()) || title.ToLower().Contains(f.ToLower()))
					   ?? "logo") + ".jpeg";

			ImageFile = ImageFile.Replace(" ", "-");

			var response = new InternshipResponse()
			{
				City = location,
				Internship = title,
				LocationLinks = string.Join(" ", LocationLink),
				ImageFile = ImageFile,
				InternshipWihHypen = $"https://cdn.kgetechnologies.com/images/Internship/{ImageFile}",
				AbsoluteUri = Helper.AbsoluteUri
			};


			return View(response);

		}


		private string LocationLinks(string City, string Internship)
		{
			var url = BuildUrl(City, Internship);
			return $"<li><a href=\"{url}\" target = \"_blank\">{Internship} Internship </a ></li>";
		}

		private string BuildUrl(string City, string Internship)
		{
			var hypenCity = Hypen(City);
			var hypenIntern = Hypen(Internship);
			return $"https://www.kgetechnologies.com/{hypenIntern}-internship-in-{hypenCity}";
		}


		private string Hypen(string input)
		{

			return input.Replace(" ", "-");
		}

		public List<String> InternshipAreas
		{
			get
			{
				return new List<string>() { "AWS", "Azure", "Google", "Android", "IOS", "Flutter", "Html Bootstrap", "Web Development","Python",
					"Website Builder", "Photoshop", "CorelDraw", "Animation", "Angular", "ReactJs", "WordPress", "Php", "Laravel",
					"Asp DotNet", "Mvc DotNet", "Java", "Sql", "Oracle", "ERP", "CRM", "Manual Testing", "Automation Testing", "Hr",
					"Marketing", "Finance", "Business Development", "Legal", "Project Management","Law", "Graphics Designer" ,"Digital Marketing", "SEO" };
			}
		}
	}
}