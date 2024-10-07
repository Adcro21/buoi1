using System.Web;
using System.Web.Mvc;

namespace NguyenPhuocHien_KtraFE1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
