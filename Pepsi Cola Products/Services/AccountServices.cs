using Pepsi_Cola_Products.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;

namespace Pepsi_Cola_Products.Services
{
    public class AccountServices
    {
        public static Dictionary<string, string> parameter = new Dictionary<string, string>();
        public static DataTable Register(Users.Register register)
        {
            try
            {
                parameter.Clear();
                parameter = new Dictionary<string, string>
                {
                    {"@username", register.username },
                    {"@FirstName", register.FirstName },
                    {"@LastName", register.LastName },
                    {"@Email", register.Email },
                    {"@Password", register.Password }
                };
                var query = "insert into users(username, FirstName, LastName, Email, Password) VALUES (@username, @FirstName, @LastName, @Email, @Password)";
                return SqlRequest.ExecuteQuery(query, parameter);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable Login(Users.Login login)
        {
            try
            {
                parameter.Clear();
                parameter = new Dictionary<string, string>
                {
                    {"@username", login.username },
                    {"@Password", login.Password }
                };
                var query = "select * from users where username = @username and Password = @Password";
                return SqlRequest.ExecuteQuery(query, parameter);
            }
            catch (Exception)
            {
                throw; 
            }
        }

        

    }
}