using System.Web;
using System.Web.Mvc;

namespace HoangTruongManhCuong_2122110167
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
