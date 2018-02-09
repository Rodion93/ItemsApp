using System.Web;
using System.Web.Mvc;

namespace AngularAndWebApi
{
    /// <summary>
    /// Filter Config
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Refister global filters
        /// </summary>
        /// <param name="filters">Collection of filters</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
