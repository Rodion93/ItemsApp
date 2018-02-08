using AngularAndWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularAndWebApi.Controllers
{
    public class StatisticController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: api/statistic
        public IQueryable<object> GetSortedItems()
        {
            var list = db.Items.GroupBy(x => x.Type).Select(g => new { Name = g.Key, Count = g.Count() });
            return list;
        }
    }
}
