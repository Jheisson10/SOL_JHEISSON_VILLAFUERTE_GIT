using System.Web;
using System.Web.Mvc;

namespace SOL_JHEISSON_VILLAFUERTE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
