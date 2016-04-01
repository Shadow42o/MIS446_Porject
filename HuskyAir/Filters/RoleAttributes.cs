//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using HuskyAir.Models;

//namespace HuskyAir.Filters
//{
//    public class RoleAttributes : AuthorizeAttribute
//    {
//        public override void OnAuthorization(HttpActionContext actionContext)
//        {
//            if (HttpContext.Current.Session["User"] == null)
//                base.HandleUnauthorizedRequest(actionContext);
//        }

//        //protected override bool AuthorizeCore(HttpContextBase httpContext)
//        //{
//        //    if (HttpContext.Current.Server["User"] == null)
//        //        base.HandleUnauthorizedRequest(httpContext);

//        //    return base.AuthorizeCore(httpContext);
//        //}
//    }
//}