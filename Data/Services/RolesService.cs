using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ProjektInzynierskiBlazor.Data.Services
{
    public class RolesService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RolesService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get list of all roles
        public async Task<List<IdentityRole>> GetAllRolesAsync()
        {
            return await _applicationDbContext.Roles.ToListAsync();
        }

        //Insert role
        public async Task<bool> InsertRoleAsync(IdentityRole role)
        {
            role.Id = Guid.NewGuid().ToString();
            await _applicationDbContext.Roles.AddAsync(role);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get role by Id
        public async Task<IdentityRole> GetRoleAsync(string Id)
        {
            IdentityRole role = await _applicationDbContext.Roles.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return role;
        }

        //Update role
        public async Task<bool> UpdateRoleAsync(IdentityRole role)
        {
            _applicationDbContext.Roles.Update(role);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete role
        public async Task<bool> DeleteRoleAsync(IdentityRole role)
        {
            _applicationDbContext.Remove(role);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
