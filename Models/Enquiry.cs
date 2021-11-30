namespace kgetechnologies.com.Models
{
    public class Enquiry
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string MobileNumber { get; set; }
        public string EnquiredFor { get; set; }
        public string AntiForgeryToken { get; set; }

    }
}