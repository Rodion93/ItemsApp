using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularAndWebApi.Models
{
    /// <inheritdoc />
    public class ApplicationContext : DbContext
    {
        /// <inheritdoc />
        public ApplicationContext() : base("DefaultConnection")
        {

        }

        /// <summary>
        /// Items DbSet
        /// </summary>
        public DbSet<Item> Items { get; set; }
    }
}