using Microsoft.EntityFrameworkCore;
using ProjektInzynierskiBlazor.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data.Services
{
    public class DepartmentService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public DepartmentService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get list of all employees
        public async Task<List<Department>> GetAllDepartmentsAsync()
        {
            return await _applicationDbContext.Departments.ToListAsync();
        }

        //Insert Department
        public async Task<bool> InsertDepartmentAsync(Department department)
        {
            department.Id = Guid.NewGuid().ToString();
            await _applicationDbContext.Departments.AddAsync(department);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get department by Id
        public async Task<Department> GetDepartmentAsync(string Id)
        {
            Department department = await _applicationDbContext.Departments.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return department;
        }

        //Update department
        public async Task<bool> UpdateDepartmentAsync(Department department)
        {
            _applicationDbContext.Departments.Update(department);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete department
        public async Task<bool> DeleteDepartmentAsync(Department department)
        {
            _applicationDbContext.Remove(department);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
