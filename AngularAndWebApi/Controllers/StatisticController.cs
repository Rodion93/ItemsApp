using AngularAndWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularAndWebApi.Controllers
{
    /// <summary>
    /// Controller for page Statistic
    /// </summary>
    public class StatisticController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        /// <summary>
        /// Get list of items for count field "Type"
        /// </summary>
        /// <returns>List of items, that contains of Type and Count</returns>
        public IQueryable<object> GetSortedItems()
        {
            var list = db.Items.GroupBy(x => x.Type).Select(g => new { Name = g.Key, Count = g.Count() });
            return list;
        }
    }
}
