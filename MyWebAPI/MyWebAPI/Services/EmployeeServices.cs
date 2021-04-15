using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebModels.Database;
using MyWebModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Services
{
    public interface IEmployeeServices
    {
        Task<ActionResult<IEnumerable<Employee>>> GetAll();
        Employee Find(int id);
        Task<ActionResult<bool>> Add(Employee employee);
        Task<ActionResult<bool>> Update(Employee employee);
        Task<ActionResult<bool>> Delete(int id);
        Task<bool> IsExists(int id);
    }

    public class EmployeeServices : IEmployeeServices
    {
        private readonly AppDbContext context;

        public EmployeeServices(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<ActionResult<bool>> Add(Employee employee)
        {
            context.Add(employee);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<ActionResult<bool>> Delete(int id)
        {
            context.Remove(Find(id));
            await context.SaveChangesAsync();
            return true;
        }

        public Employee Find(int id)
        {
            return context.Employees.FirstOrDefault(x => x.id == id);
        }

        public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
        {
            return await context.Employees.ToListAsync();
        }

        public async Task<bool> IsExists(int id)
        {
            return await context.Employees.AnyAsync(x => x.id == id);
        }

        public async Task<ActionResult<bool>> Update(Employee employee)
        {
            context.Update(employee);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
