using Dapper;
using kgetechnologies.com.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
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
                var split = id.Split('.')[0].Split('_');
                //Finance_part3
                var term = split[0];
                var part = split[1];
                
                var internship = Hypen(term);
                var citiesList = LoadCitiesFromGit(part) ?? LoadCities();

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

        private List<Cities> LoadCitiesFromGit(string part)
        {
            part = part.Replace("part", "");

            var url = $"https://cdn.kgetechnologies.comSitemap/Cities{part}.csv";
            var html = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "C# console client";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            return html?.Split('\n')?.Select(f => new Cities() { City = f })?.ToList();
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