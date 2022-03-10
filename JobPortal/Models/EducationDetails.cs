using System;

namespace CustomAuthorizationFilter.Models
{
    public class EducationDetails
    {
        public User user { get; set; }
        public int Id { get; set; }
        public string EducationName { get; set; }
        public string ManthAndYearOfPassing { get; set; }
        public float Percentage { get; set; }
        
    }
}