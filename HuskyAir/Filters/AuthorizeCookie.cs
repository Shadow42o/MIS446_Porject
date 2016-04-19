using HuskyAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HuskyAir.CustomAttributes
{
    public class AuthorizeCookie : AuthorizeAttribute
    {
        DBModelsMaster context = new DBModelsMaster(); // my entity  
        private readonly string[] allowedroles;
        public AuthorizeCookie(params string[] roles)
        {
            this.allowedroles = roles;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
            foreach (var role in allowedroles)
            {
                var user = context.UserAccounts.Where(m => m.Username == httpContext.User.Identity.Name/* getting user form current context */ && m.Role == role ); // checking active users with allowed roles.  
                if (user.Count() > 0)
                {
                    authorize = true; /* return true if Entity has current user(active) with specific role */
                }
            }
            return authorize;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new HttpUnauthorizedResult();
        }
    }
}