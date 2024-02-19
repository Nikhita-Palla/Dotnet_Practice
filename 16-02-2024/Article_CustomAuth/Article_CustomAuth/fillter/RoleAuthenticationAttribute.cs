using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Filters;
using System.Web.Mvc;
using System.Web.Routing;
using System.Net.Http;

namespace Article_CustomAuth.fillter
{
    public class RoleAuthenticationAttribute : ActionFilterAttribute, IAuthenticationFilter
    {
        private readonly string[] _roles;

        public RoleAuthenticationAttribute(params string[] roles)
        {
            _roles = roles;
        }

        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.Result = new HttpUnauthorizedResult();
                return;
            }

            foreach (var role in _roles)
            {
                if (!filterContext.HttpContext.User.IsInRole(role))
                {
                    return;
                }
            }

            filterContext.Result = new HttpUnauthorizedResult();
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new ViewResult { ViewName = "Error" };

            }
        }
    }
}