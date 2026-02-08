using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pepsi_Cola_Products.Models
{
    public class Users
    {
        public class Register
        {
            public string username { get; set; }
            public string FirstName {  get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class Login
        {
            public string username { get; set; }
            public string Password { get; set; }
        }
    }
}