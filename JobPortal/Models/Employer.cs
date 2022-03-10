using System;

namespace CustomAuthorizationFilter.Models
{
    public class Employer
    {
        User user { get; set; }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string CompanyType { get; set; }
        public string PinCode { get; set; }
        public string GSTIN { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}