using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test_MVC.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage="Please enter your email address")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage="Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage="Please enter your phone number")]
        [RegularExpression(@"^([+0][8][8])?[0][1][15-9]\d{8}$", ErrorMessage="Please enter a valid mobile number like +8801XXXXXXXX or 08801XXXXXXXXX or 01XXXXXXXXX")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage="Please specify if you will come or not!")]
        public bool? WillAttend { get; set; }

    }
}