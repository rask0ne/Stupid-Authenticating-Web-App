using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Stupid_Authenticating_Web_App.Controllers
{
    public class RequiresRoleAttribute : ActionFilterAttribute
    {
        public string Role { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (string.IsNullOrEmpty(Role))
            {
                throw new InvalidOperationException("No role specified.");
            }

            string redirectOnSuccess = filterContext.HttpContext.Request.Url.AbsolutePath;
            string redirectUrl = string.Format("?returnUrl={0}", redirectOnSuccess);
            string loginUrl = FormsAuthentication.LoginUrl + redirectUrl;

            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.HttpContext.Response.Redirect(loginUrl, true);
            }
            else
            {
                bool isAuthorised = filterContext.HttpContext.User.IsInRole(this.Role);
                if (!isAuthorised)
                {
                    filterContext.HttpContext.Response.Redirect(loginUrl, true);
                }
            }
        }
    }
}