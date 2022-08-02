using EmployeeApiConsume.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace EmployeeApiConsume.Controllers
{
    public class EmployeeController : Controller
    {
        Uri baseuri = new Uri("https://localhost:7044/api");
        HttpClient client = new HttpClient();
        List<Employee> Employeedata = new List<Employee>();
        public IActionResult Index()
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "/Employee").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            Employeedata = JsonConvert.DeserializeObject<List<Employee>>(data);
            return View(Employeedata);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Createmployee(Employee employee)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7044/api/Employee");
                var postTask = client.PostAsJsonAsync<Employee>("Employee", employee);
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
            HttpResponseMessage response = client.GetAsync(baseuri + "/Employee").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            Employeedata = JsonConvert.DeserializeObject<List<Employee>>(data);
            var emp = Employeedata.Where(e => e.Id == id).FirstOrDefault();
            return View(emp);
        }
        [HttpPost]
        public IActionResult Save(Employee employee)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7044/api/");
                var put = client.PutAsJsonAsync($"Employee?empId={employee.Id}", employee);
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
                client.BaseAddress = new Uri("https://localhost:7044/api/");
                var put = client.DeleteAsync($"Employee?empId={id}");
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

        public ActionResult Search(string searchString)
        {
            List<Employee> employees = new List<Employee>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/employee/" + searchString).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                employees = JsonConvert.DeserializeObject<List<Employee>>(data);
            }
            return View("Index", employees);
        }
    }
}


    
