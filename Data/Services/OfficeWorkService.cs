using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektInzynierskiBlazor.Data.Entities;

namespace ProjektInzynierskiBlazor.Data.Services
{
    public class OfficeWorkService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public OfficeWorkService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get list of all officeWorks
        public async Task<List<OfficeWork>> GetAllOfficeWorksAsync()
        {
            return await _applicationDbContext.OfficeWorks.ToListAsync();
        }

        //Insert officeWork
        public async Task<bool> InsertOfficeWorkAsync(OfficeWork officeWork)
        {
            officeWork.Id = Guid.NewGuid().ToString();
            await _applicationDbContext.OfficeWorks.AddAsync(officeWork);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get officeWork by Id
        public async Task<OfficeWork> GetOfficeWorkAsync(string Id)
        {
            OfficeWork officeWork = await _applicationDbContext.OfficeWorks.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return officeWork;
        }

        //Update officeWork
        public async Task<bool> UpdateOfficeWorkAsync(OfficeWork officeWork)
        {
            _applicationDbContext.OfficeWorks.Update(officeWork);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete officeWork
        public async Task<bool> DeleteOfficeWorkAsync(OfficeWork officeWork)
        {
            _applicationDbContext.Remove(officeWork);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
