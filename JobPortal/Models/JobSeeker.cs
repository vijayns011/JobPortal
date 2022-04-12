using System;

namespace CustomAuthorizationFilter.Models
{
    public class JobSeeker
    {
        User user { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string TotalYearsOfExperience { get; set; }
        public string AnnualSalaryLPA { get; set; }
        public string AnnualSalaryThousand { get; set; }
        public string CurrentLocation { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}