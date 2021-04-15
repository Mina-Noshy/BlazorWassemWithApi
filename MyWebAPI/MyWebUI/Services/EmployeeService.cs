using MyWebModels.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MyWebUI.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> Find(int id);
        Task<bool> Add(Employee employee);
        Task<bool> Update(Employee employee);
        Task<bool> Delete(int id);
    }

    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient http;

        public EmployeeService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<bool> Add(Employee employee)
        {
            var json = JsonConvert.SerializeObject(employee);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await http.PostAsync("employees", content);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            await http.DeleteAsync($"employees/{id}");
            return true;
        }

        public async Task<Employee> Find(int id)
        {
            return await http.GetFromJsonAsync<Employee>($"employees/{id}");
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await http.GetFromJsonAsync<ICollection<Employee>>("employees");
        }


        public async Task<bool> Update(Employee employee)
        {
            var json = JsonConvert.SerializeObject(employee);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await http.PutAsync($"employees/{employee.id}", content);
            return true;
        }
    }
}
