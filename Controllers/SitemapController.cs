using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Xml.Serialization;

namespace kgetechnologies.Controllers
{
    public class SitemapController : Controller
    {
        public async Task<IActionResult> Pages()
        {
            return View();
        }

        public async Task<IActionResult> InternLocation(string technology, string partNumber)
        {
            var product = new { technology , partNumber };

            // Serialize a single product to XML
            var serializer = new XmlSerializer(typeof(object));
            using (var stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, product);
                var xmlContent = stringWriter.ToString();

                return Content(xmlContent, "application/xml", Encoding.UTF8);
            }
        }
    }
}
