using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjektInzynierskiBlazor.Data.Entities;

namespace ProjektInzynierskiBlazor.Data.Services
{
    public class RolesAccessService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RolesAccessService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Insert rolesAccess
        public async Task<bool> InsertRolesAccessAsync(RolesAccess rolesAccess)
        {
            rolesAccess.Id = Guid.NewGuid().ToString();
            await _applicationDbContext.RolesAccesses.AddAsync(rolesAccess);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get list of all rolesAccesses
        public async Task<List<RolesAccess>> GetAllRolesAccessesAsync()
        {
            return await _applicationDbContext.RolesAccesses.ToListAsync();
        }

        //Get rolesAccess by Id
        public async Task<RolesAccess> GetRolesAccessAsync(string Id)
        {
            RolesAccess rolesAccess = await _applicationDbContext.RolesAccesses.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return rolesAccess;
        }

        //Get rolesAccess by Name
        public async Task<RolesAccess> GetRolesAccessByNameAsync(string Name)
        {
            RolesAccess rolesAccess = await _applicationDbContext.RolesAccesses.FirstOrDefaultAsync(x => x.Name.Equals(Name));
            return rolesAccess;
        }

        //Update rolesAccess
        public async Task<bool> UpdateRolesAccessAsync(RolesAccess rolesAccess)
        {
            _applicationDbContext.RolesAccesses.Update(rolesAccess);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete rolesAccess
        public async Task<bool> DeleteRolesAccessAsync(RolesAccess rolesAccess)
        {
            _applicationDbContext.Remove(rolesAccess);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }

}
