using Dapper;
using kgetechnologies.com.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Xml.Linq;

namespace kgetechnologies.com.Controllers
{
    public class sitemapController : Controller
    {
        // GET: sitemap
        public ActionResult Index(string id = "")
        {
            var op = new List<SitemapNode>();
            if (string.IsNullOrEmpty(id) || id.Equals("pages", StringComparison.OrdinalIgnoreCase))
            {
                op = pageLinkList().Select(f => new SitemapNode()
                {
                    Frequency = SitemapFrequency.Daily,
                    LastModified = DateTime.UtcNow.AddDays(-1),
                    Priority = 0.2,
                    Url = $"https://www.kgetechnologies.com/{Hypen(f)}"
                }).ToList();

                op.Add(new SitemapNode()
                {
                    Frequency = SitemapFrequency.Daily,
                    LastModified = DateTime.UtcNow.AddDays(-1),
                    Priority = 0.2,
                    Url = $"https://www.kgetechnologies.com"
                });

            }
            else
            {
                var internship = Hypen(id.Split('.')[0]);
                var citiesList = LoadCities();

                op = citiesList.Select(f => new SitemapNode()
                {
                    Frequency = SitemapFrequency.Daily,
                    LastModified = DateTime.UtcNow.AddDays(-1),
                    Priority = 0.2,
                    Url = $"https://www.kgetechnologies.com/{internship}-internship-in-{Hypen(f.City)}"
                }).ToList();

            }
            return this.Content(GetSitemapDocument(op), "application/xml", Encoding.UTF8);
        }

        //
        public string GetSitemapDocument(IEnumerable<SitemapNode> sitemapNodes)
        {
            XNamespace xmlns = "http://www.sitemaps.org/schemas/sitemap/0.9";
            XElement root = new XElement(xmlns + "urlset");

            foreach (SitemapNode sitemapNode in sitemapNodes)
            {
                XElement urlElement = new XElement(
                    xmlns + "url",
                    new XElement(xmlns + "loc", Uri.EscapeUriString(sitemapNode.Url)),
                    sitemapNode.LastModified == null ? null : new XElement(
                        xmlns + "lastmod",
                        sitemapNode.LastModified.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:sszzz")),
                    sitemapNode.Frequency == null ? null : new XElement(
                        xmlns + "changefreq",
                        sitemapNode.Frequency.Value.ToString().ToLowerInvariant()),
                    sitemapNode.Priority == null ? null : new XElement(
                        xmlns + "priority",
                        sitemapNode.Priority.Value.ToString("F1", CultureInfo.InvariantCulture)));
                root.Add(urlElement);
            }

            XDocument document = new XDocument(root);
            return document.ToString();
        }
        private string Hypen(string input)
        {
            return input.Replace(' ', '-');
        }

        private List<Cities> LoadCities()
        {
            string sql = "SELECT distinct trim(city) city FROM [Cities]";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cities"].ConnectionString))
            {
                connection.Open();

                using (var multi = connection.QueryMultiple(sql))
                {
                    return multi.Read<Cities>()?.AsList() ?? new List<Cities>() { };
                }
            }


        }


        private List<string> pageLinkList()
        {
            return new List<string>()
            {
                "services",
"Seo",
"GraphicsDesign",
"WebHosting",
"LogoDesign",
"CloudSupport",
"Marketing",
"DigitalMarketing",
"EmailMarketing",
"WhatsappMarketing",
"SmsMarketing",
"PpcMarketting",
"Development",
"Application",
"MobileApps",
"Internship",
"Cloud",
"AWS",
"Azure",
"Google",
"MobileApps",
"Android",
"IOS",
"Flutter",
"WebDevelopment",
"UIDeveloper",
"UXDeveloper",
"Angular",
"React",
"ECommerce",
"Wordpress",
"CustomERP",
"DotNet",
"Java",
"SQL",
"ERP",
"CRM",
"Testing",
"Manual",
"Automation",
"Management",
"HR",
"Finance",
"MarketingIntern",
"Business",
"Legal",
"Project",
"MoreDetails",
"OurTeam",
"Process",
"ReachUs",
"Terms",
"Privacy",
"ReachUs",

            };
        }
    }
}