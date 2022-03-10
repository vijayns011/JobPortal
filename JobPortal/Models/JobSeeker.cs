using System;

namespace CustomAuthorizationFilter.Models
{
    public class JobSeeker
    {
        User user { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}