using System.Web;
using System.Web.Mvc;

namespace MvcDashboard_SetMasterFilter {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}