using System.Web;
using System.Web.Mvc;

namespace Oct23_2017LibraryAppDBDrivenWalkthrough
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
