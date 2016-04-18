using HuskyAir.Models;//Added
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;//Added

namespace HuskyAir
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //protected void Application_AuthorizeRequest(object sender, EventArgs e)
        //{
        //    if (HttpContext.Current.User != null)
        //    {
        //        if (HttpContext.Current.User.Identity.IsAuthenticated)
        //        {
        //            if (HttpContext.Current.User.Identity is FormsIdentity)
        //            {
        //                FormsIdentity id =
        //                    (FormsIdentity)HttpContext.Current.User.Identity;
        //                FormsAuthenticationTicket ticket = id.Ticket;

        //                // Get the stored user-data, in this case, our roles
        //                string userData = ticket.UserData;
        //                string[] roles = userData.Split(',');
        //                HttpContext.Current.User = new GenericPrincipal(id, roles);

        //                System.Diagnostics.Debug.WriteLine("SomeText");
        //            }
        //        }
        //    }
        //}

        //protected void Application_AuthenticateRequest(object sender, EventArgs e)
        //{
        //    var authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];

        //    if (authCookie != null)
        //    {
        //        var ticket = FormsAuthentication.Decrypt(authCookie.Value);

        //        FormsIdentity formsIdentity = new FormsIdentity(ticket);

        //        ClaimsIdentity claimsIdentity = new ClaimsIdentity(formsIdentity);

        //        var user = this.UserService.GetUserByEmail(ticket.Name);

        //        foreach (var role in user.Roles)
        //        {
        //            claimsIdentity.AddClaim(
        //                new Claim(ClaimTypes.Role, role));
        //        }

        //        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

        //        HttpContext.Current.User = claimsPrincipal;
        //    }
        //}

        //Extra Code; Override Authentication Methods
        //protected void Application_AuthorizeRequest(Object sender, FormsAuthenticationEventArgs e)//Application_AuthenticateRequest
        //{
        //    if (FormsAuthentication.CookiesSupported == true)
        //    {
        //        if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
        //        {
        //            try
        //            {
        //                string username = FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name;
        //                string roles = string.Empty;

        //                using (UserAccountModels entities = new UserAccountModels())
        //                {
        //                    UserAccount user = entities.UserAccounts.SingleOrDefault(u => u.Username == username);
        //                    roles = user.Role;
        //                }

                       

        //                //Extract role from cookie
        //                //Set principal
        //                e.User = new System.Security.Principal.GenericPrincipal(
        //                    new System.Security.Principal.GenericIdentity(username, "Forms"), roles.Split(';'));
        //            }
        //            catch (Exception)
        //            {
        //                //something went wrong
        //            }
        //        }
            //}
        //}
    }
}
