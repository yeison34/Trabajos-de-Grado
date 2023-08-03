using System.Web;
using System.Web.Mvc;

namespace Trabajos_de_Grado_UDENAR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
