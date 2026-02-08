using System.Web;
using System.Web.Mvc;

namespace Pepsi_Cola_Products
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
