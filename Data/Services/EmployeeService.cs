using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjektInzynierskiBlazor.Data.Entities;

namespace ProjektInzynierskiBlazor.Data.Services
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EmployeeService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get list of all employees
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _applicationDbContext.Employees.ToListAsync();
        }

        //Insert employee
        public async Task<bool> InsertEmployeeAsync(Employee employee)
        {
            employee.Id = Guid.NewGuid().ToString();
            await _applicationDbContext.Employees.AddAsync(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get employee by Id
        public async Task<Employee> GetEmployeeAsync(string Id)
        {
            Employee employee = await _applicationDbContext.Employees.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return employee;
        }

        //Update employee
        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            _applicationDbContext.Employees.Update(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete employee
        public async Task<bool> DeleteEmployeeAsync(Employee employee)
        {
            _applicationDbContext.Remove(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
