using System.Web;
using System.Web.Mvc;

namespace BambooWebDeploy
{
    //adding a comment for github testing
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
