using System;

namespace CustomAuthorizationFilter.Models
{
    public class JobDetails
    {
        public User user { get; set; }
        public int Id { get; set; }
        public string JobName { get; set; }
        public string StartFrom { get; set; }
        public string EndTo { get; set; }
        public string TechnologiesUsed { get; set; }
        public string Overview { get; set; }


    }
}