using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookApi.Models;

namespace BookApi.Controllers
{
    public class AuthorsController : ApiController
    {
        StoreContext db = new StoreContext();
        public IEnumerable<Author> GetAuthors()
        {
            return db.Authors;
        }
        /// <summary>
        /// Return Information About Author
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Author GetAuthor(int id)
        {
            Author author = db.Authors.Find(id);
            return author;
        }

        /// <summary>
        /// Add Author and Send Created in Success And Conflict if Failed
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        public HttpResponseMessage PostAuthor(Author author)
        {
            if (ModelState.IsValid)
            {
                db.Authors.Add(author);
                db.SaveChanges();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
               return response;
            }
            else
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Conflict);
                return response;
            }
        }
        /// <summary>
        /// Update Existing Author
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        public HttpResponseMessage PutAuthor(Author author)
        {
            db.Entry(author).State = EntityState.Modified;
            db.SaveChanges();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
        /// <summary>
        /// Delete Author From Table Authors in DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HttpResponseMessage DeleteAuthor(int id)
        {
            Author author = db.Authors.Find(id);
            if (author != null) db.Authors.Remove(author);
            db.SaveChanges();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
}
