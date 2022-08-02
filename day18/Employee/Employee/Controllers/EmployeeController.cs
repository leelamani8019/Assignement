
using Employee.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

//For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller

    {

        private readonly Employeedata _employeedata;

        public EmployeeController(Employeedata employeedata) { _employeedata = employeedata; }



        [HttpGet]
        public ActionResult<Employees> GetEmployees()
        {
            return Ok(_employeedata.employeesList);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Employees employee)
        {
           _employeedata.employeesList.Add(employee);
            return Ok(_employeedata.employeesList);
        }

        [HttpPut]
        public  IActionResult UpdateOneEmployee(int empId, Employees employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee object can't be null");
            }
            if (_employeedata.employeesList == null)
            {
                return NotFound("Table doesn't exists");
            }
            var employeeToUpdate =  _employeedata.employeesList.Where(e => e.Id == empId).FirstOrDefault();
            if (employeeToUpdate == null)
            {
                return NotFound("Employee with this empId doesn't exists");
            }
            _employeedata.employeesList.Remove(employeeToUpdate);
            employeeToUpdate.Id=employee.Id;
            employeeToUpdate.Name = employee.Name;
            employeeToUpdate.phonenumber = employee.phonenumber;
            employeeToUpdate.Email = employee.Email;
            employeeToUpdate.city = employee.city;
            employeeToUpdate.age = employee.age;

            _employeedata.employeesList.Add(employeeToUpdate);
            return Ok(_employeedata.employeesList);
        }

        [HttpDelete]
        public ActionResult DeleteOneEmployee(int empId)
        {
            if (_employeedata.employeesList == null)
            {
                return NotFound("Table doesn't exists");
            }
            var employeeToDelete =  _employeedata.employeesList.Where(e => e.Id == empId).FirstOrDefault();
            if (employeeToDelete == null)
            {
                return NotFound("Employee with this empId doesn't exists");
            }
            _employeedata.employeesList.Remove(employeeToDelete);
            return Ok(_employeedata.employeesList);
        }

    }
}