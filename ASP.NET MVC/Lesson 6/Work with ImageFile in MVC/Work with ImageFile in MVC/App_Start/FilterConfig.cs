using System.Web;
using System.Web.Mvc;

namespace Work_with_ImageFile_in_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
