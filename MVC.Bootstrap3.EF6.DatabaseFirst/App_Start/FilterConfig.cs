using System.Web;
using System.Web.Mvc;

namespace MVC.Bootstrap3.EF6.DatabaseFirst
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
