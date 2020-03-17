using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LayoutsMVC.Models
{
    public class LoginValidation
    {
        string username;
        string password;
        [Required(ErrorMessage ="Username is required")]
        public string Username { get => username; set => username = value; }
        [Required(ErrorMessage ="password is required")]
        public string Password { get => password; set => password = value; }
    }

}