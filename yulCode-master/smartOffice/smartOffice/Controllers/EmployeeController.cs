using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smartOffice.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace smartOffice.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        //get request
        //public static async Task<List<Employee>> GetAllEmployeesAsync(string path)
        public static async Task<List<Employee>> GetAllEmployeesAsync()
        {
            List<Employee> employees = new List<Employee>();
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://staryu.azurewebsites.net/yulcode/employees"); ;
                Console.WriteLine(response.StatusCode);
                if (response.IsSuccessStatusCode)
                {
                    employees = await response.Content.ReadAsAsync<List<Employee>>();
                }
                return employees;
            }
        }

        //get request
        //public static async Task<Employee> GetEmployeeAsync(string path, int id)
        public static async Task<Employee> GetEmployeeAsync(int id)
        {
            Employee employee = null;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://staryu.azurewebsites.net/yulcode/employees" + id); ;
                Console.WriteLine(response.StatusCode);
                if (response.IsSuccessStatusCode)
                {
                    employee = await response.Content.ReadAsAsync<Employee>();
                }
                return employee;
            }
        }

        //put request
        public static async Task<Employee> MoveEmployeeAsync(Employee employee, int roomId)
        {
            using (var client = new HttpClient())
            {
                //HttpResponseMessage response = await client.PutAsJsonAsync(
                //$"api/products/{employee.Id}", employee);
                //response.EnsureSuccessStatusCode();

                HttpResponseMessage response = await client.PutAsJsonAsync(
                "https://staryu.azurewebsites.net/yulcode/" + employee.id + "/" + roomId, employee);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                employee = await response.Content.ReadAsAsync<Employee>();
                return employee;
            }
        }
    }
}
