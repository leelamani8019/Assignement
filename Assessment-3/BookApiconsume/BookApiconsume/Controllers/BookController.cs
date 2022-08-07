using BookApiconsume.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookApiconsume.Controllers
{
    public class BookController : Controller
    {
        Uri baseuri = new Uri("https://localhost:7103/api");

        HttpClient client = new HttpClient();
        List<Books> bookdata = new List<Books>();
        List<Books> books = new List<Books>();
        public BookController()
        {
            client.BaseAddress = baseuri;
            

        }
        public IActionResult Index()
        {
            client .BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "/Books").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            bookdata = JsonConvert.DeserializeObject<List<Books>>(data);
            return View(bookdata);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatBook(Books books)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7103/api/Books");
                var postTask = client.PostAsJsonAsync<Books>("Books", books);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "server error");
            return View();
        }
        public ActionResult Edit(int id)
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "/Books").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            bookdata = JsonConvert.DeserializeObject<List<Books>>(data);
            var emp = bookdata.Where(e => e.Id == id).FirstOrDefault();
            return View(emp);
        }
        [HttpPost]
        public IActionResult Save(Books books)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7103/api/");
                var put = client.PutAsJsonAsync($"Books?bookid={books.Id}", books);
                put.Wait();
                var result = put.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

            }
            ModelState.AddModelError(string.Empty, "server error");
            return View();

        }
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7103/api/Books/");
                var put = client.DeleteAsync($"id?id={id}");
                put.Wait();
                var result = put.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

            }
            ModelState.AddModelError(string.Empty, "server error");
            return View();
        }
        public ActionResult Details(int id)
        {
            client.BaseAddress = baseuri; 
            HttpResponseMessage response = client.GetAsync(baseuri + $"/Books/id?Id={id}").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            var book = JsonConvert.DeserializeObject<Books>(data);
            return View(book);

        }
        public ActionResult search(string search)
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "/Books").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            books = JsonConvert.DeserializeObject<List<Books>>(data);
            var search_book = books.Where(e => e.Name.Contains(search) || e.Zoner.Contains(search)).ToList();
            return View("Index", search_book);

        }
        public ActionResult AddCart(int id)
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "Books").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            bookdata = JsonConvert.DeserializeObject<List<Books>>(data);
            var book = bookdata.Where(e => e.Id == id).FirstOrDefault();
            if (book == null)
            {
                return NoContent();
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7103/api/");

                //HTTP POST

                var postTask = client.PostAsJsonAsync<Books>("Cart",book );

                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)

                {

                    return RedirectToAction("Home");
                }

            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View();

        }
        public ActionResult Cart()
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "Cart").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            bookdata = JsonConvert.DeserializeObject<List<Books>>(data);
            return View(bookdata);
        }
        public ActionResult DeleteinCart(int id)
        {
            using (var client = new HttpClient())

            {
                client.BaseAddress = new Uri("https://localhost:7103/api/Cart/");
                var delete = client.DeleteAsync($"{id}");
                delete.Wait();
                var results = delete.Result;
                if (results.IsSuccessStatusCode)
                {
                    return RedirectToAction("Cart");
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View();
        }

    }
    }
