using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data
{
    public class OrdererService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public OrdererService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get list of all orderers
        public async Task<List<Orderer>> GetAllOrderersAsync()
        {
            return await _applicationDbContext.Orderers.ToListAsync();
        }

        //Insert orderer
        public async Task<bool> InsertOrdererAsync(Orderer orderer)
        {
            orderer.Id = Guid.NewGuid().ToString();
            await _applicationDbContext.Orderers.AddAsync(orderer);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get orderer by Id
        public async Task<Orderer> GetOrdererAsync(string Id)
        {
            Orderer orderer = await _applicationDbContext.Orderers.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return orderer;
        }

        //Update orderer
        public async Task<bool> UpdateOrdererAsync(Orderer orderer)
        {
            _applicationDbContext.Orderers.Update(orderer);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete orderer
        public async Task<bool> DeleteOrdererAsync(Orderer orderer)
        {
            _applicationDbContext.Remove(orderer);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
