using System.Web;
using System.Web.Mvc;

namespace buoi4_BuiMinhQuang
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
