
using ArticleCRUD.filters;
using System.Web;
using System.Web.Mvc;

namespace ArticleCRUD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new UserAuthenticationAttribute());
            
        }
    }
}

