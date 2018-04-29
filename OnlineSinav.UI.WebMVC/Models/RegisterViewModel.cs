using OnlineSinav.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineSinav.UI.WebMVC.Models
{
    public class RegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }

    }
}