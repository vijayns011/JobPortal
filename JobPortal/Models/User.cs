﻿using System.ComponentModel.DataAnnotations;

namespace CustomAuthorizationFilter.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "User Id")]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}