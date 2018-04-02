using System.Web;
using System.Web.Mvc;

namespace supinfo._3asp.koombu
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
