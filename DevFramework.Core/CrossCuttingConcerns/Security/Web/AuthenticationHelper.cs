using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace DevFramework.Core.CrossCuttingConcerns.Security.Web
{
   public class AuthenticationHelper
    {
        public static void CreateAuthCookie(Guid id,string userName,string Email,DateTime expiration,string[]roles
            ,bool rememberMe,string firstName,string lastName)
        {

            var authTicket = new FormsAuthenticationTicket(1, userName, DateTime.Now, expiration, rememberMe,CreateAuthTags(Email,roles,firstName,lastName,id));
            string encTicket = FormsAuthentication.Encrypt(authTicket);
            HttpContext.Current.Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName,encTicket));
        }

        private static string CreateAuthTags(string email, string[] roles, string firstName, string lastName, Guid id)
        {
            var stringbuilder = new StringBuilder();
            stringbuilder.Append(email);
            stringbuilder.Append("|");
            for (int i = 0; i < roles.Length; i++)
            {
                stringbuilder.Append(roles[i]);
                if (i < roles.Length-1) { stringbuilder.Append(","); }
                
            }
            stringbuilder.Append("|");
            stringbuilder.Append(firstName);
            stringbuilder.Append("|");
            stringbuilder.Append(lastName);
            stringbuilder.Append("|");
            stringbuilder.Append(id);
          
            return stringbuilder.ToString();


        }
    }
}
