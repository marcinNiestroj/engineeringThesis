using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ProjektInzynierskiBlazor.Data.Services
{
    public class UserRolesService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRolesService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get list of all user roles
        public async Task<List<IdentityUserRole<string>>> GetAllIdentityUserRolesAsync()
        {
            return await _applicationDbContext.UserRoles.ToListAsync();
        }

        //Insert a new user role
        public async Task<bool> InsertUserRoleAsync(IdentityUserRole<string> identityUserRole)
        {
            await _applicationDbContext.UserRoles.AddAsync(identityUserRole);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get user role by UserId
        public async Task<IdentityUserRole<string>> GetUserRoleAsync(string Id)
        {
            IdentityUserRole<string> identityUserRole = await _applicationDbContext.UserRoles.FirstOrDefaultAsync(x => x.UserId.Equals(Id));
            return identityUserRole;
        }

        //Update user role
        public async Task<bool> UpdateUserRoleAsync(IdentityUserRole<string> identityUserRole)
        {
            _applicationDbContext.UserRoles.Update(identityUserRole);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete user role
        public async Task<bool> DeleteUserRoleAsync(IdentityUserRole<string> identityUserRole)
        {
            _applicationDbContext.Remove(identityUserRole);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
