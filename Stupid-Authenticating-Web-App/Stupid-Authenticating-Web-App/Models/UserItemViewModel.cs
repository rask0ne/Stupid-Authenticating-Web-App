using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stupid_Authenticating_Web_App.Models
{
    public class UserItemViewModel
    {
        public string Email { get; set; }
        public string RoleName { get; set; }
        public string SocialNetwork { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}