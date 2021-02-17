using Hangfire.Annotations;
using Hangfire.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Work_with_Hangfire.Helper
{
    public class AuthorizationHangfireFiler : IDashboardAuthorizationFilter
    {
        public bool Authorize([NotNull] DashboardContext context)
        {
            //return HttpContext.Current.User.IsInRole("Admin");
            return HttpContext.Current.User.Identity.IsAuthenticated;
        }
    }
}