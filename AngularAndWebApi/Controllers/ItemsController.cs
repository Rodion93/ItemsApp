using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AngularAndWebApi.Models;

namespace AngularAndWebApi.Controllers
{
    /// <summary>
    /// Items Controller. Allow to add, edit, delete and get items
    /// </summary>
    public class ItemsController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        /// <summary>
        /// Get all items
        /// </summary>
        /// <returns>IQueryable collection of items</returns>
        public IQueryable<Item> GetItems()
        {
            return db.Items;
        }

        /// <summary>
        /// Get one item by Id
        /// </summary>
        /// <param name="id">Uniq item identifier</param>
        /// <returns>ContentResult(item)</returns>
        [ResponseType(typeof(Item))]
        public IHttpActionResult GetItem(int id)
        {
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        /// <summary>
        /// Update item
        /// </summary>
        /// <param name="item">Edited item</param>
        /// <returns>HttpStatusCode.NoContent</returns>
        [ResponseType(typeof(void))]
        public IHttpActionResult PutItem(Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Create item
        /// </summary>
        /// <param name="item">New item</param>
        /// <returns>Redirect</returns>
        [ResponseType(typeof(Item))]
        public IHttpActionResult PostItem(Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            db.Items.Add(item);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = item.Id }, item);
        }

        /// <summary>
        /// Delete item
        /// </summary>
        /// <param name="id">Uniq Identifyer</param>
        /// <returns>Item</returns>
        [ResponseType(typeof(Item))]
        public IHttpActionResult DeleteItem(int id)
        {
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            db.Items.Remove(item);
            db.SaveChanges();

            return Ok(item);
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ItemExists(int id)
        {
            return db.Items.Count(e => e.Id == id) > 0;
        }
    }
}