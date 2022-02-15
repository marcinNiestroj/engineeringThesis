using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get list of all users
        public async Task<List<IdentityUser>> GetAllUsersAsync()
        {
            return await _applicationDbContext.Users.ToListAsync();
        }

        //Get user by Id
        public  async Task<IdentityUser> GetUserAsync(string Id)
        {
            IdentityUser user = await _applicationDbContext.Users.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return user;
        }

        //Get user by Name
        public async Task<IdentityUser> GetUserByNameAsync(string Name)
        {
            IdentityUser user = await _applicationDbContext.Users.FirstOrDefaultAsync(x => x.UserName.Equals(Name));
            return user;
        }

        //Update user
        public async Task<bool> UpdateUserAsync(IdentityUser user)
        {
            _applicationDbContext.Users.Update(user);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

    }
}
