using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using MvcConsumeApi.Models;

namespace MvcConsumeApi.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            //1. Declare Client
            HttpClient client = new HttpClient();
            //2.Get URL
            client.BaseAddress = new Uri("http://localhost:22413/");
            //3.Declare Xml Or Json
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //4. Get Data
           HttpResponseMessage response = client.GetAsync("api/authors").Result;
           var author = response.Content.ReadAsAsync<IEnumerable<Author>>().Result;
            return View(author);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Author author)
        {
            HttpClient client = new HttpClient();
            //2.Get URL
            client.BaseAddress = new Uri("http://localhost:22413/");
            //3.Declare Xml Or Json
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //4. Get Data
           HttpResponseMessage response = client.PostAsJsonAsync("api/authors", author).Result;
            return RedirectToAction("Index");
        }
        
        public ActionResult Details(int id)
        {
            //1. Declare Client
            HttpClient client = new HttpClient();
            //2.Get URL
            client.BaseAddress = new Uri("http://localhost:22413/");
            //3.Declare Xml Or Json
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //4. Get Data
            var url = "api/authors/" + id;
            //4. Get Data
            HttpResponseMessage response = client.GetAsync(url).Result;
            var author = response.Content.ReadAsAsync< Author>().Result;
            return View(author);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //1. Declare Client
            HttpClient client = new HttpClient();
            //2.Get URL
            client.BaseAddress = new Uri("http://localhost:22413/");
            //3.Declare Xml Or Json
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //4. Get Data
            var url = "api/authors/" + id;
            //4. Get Data
            HttpResponseMessage response = client.GetAsync(url).Result;
            var author = response.Content.ReadAsAsync<Author>().Result;
            return View(author);
        }
        [HttpPost]
        public ActionResult Edit(Author author)
        {
            //1. Declare Client
            HttpClient client = new HttpClient();
            //2.Get URL
            client.BaseAddress = new Uri("http://localhost:22413/");
            //3.Declare Xml Or Json
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //4. Get Data
            HttpResponseMessage response = client.PutAsJsonAsync("api/authors", author).Result;
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            //1. Declare Client
            HttpClient client = new HttpClient();
            //2.Get URL
            client.BaseAddress = new Uri("http://localhost:22413/");
            //3.Declare Xml Or Json
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //4. Get Data
            var url = "api/authors/" + id;
            //4. Get Data
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            return RedirectToAction("Index");
        }
    }
}