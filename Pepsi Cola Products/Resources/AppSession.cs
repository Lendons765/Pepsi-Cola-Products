using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pepsi_Cola_Products.Resources
{
    public class AppSession
    {
        public class SessionTimeoutAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuted(ActionExecutedContext filterContext)
            {
                if (HttpContext.Current.Session["id"] == null)
                {
                    filterContext.Result = new RedirectResult("~/");
                    return;
                }
                base.OnActionExecuted(filterContext);
            }
        }
    }
}