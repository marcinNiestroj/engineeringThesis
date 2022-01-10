using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data
{
    public class OrderService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public OrderService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get list of Orders
        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _applicationDbContext.Orders.ToListAsync();
        }

        //Insert order
        public async Task<bool> InsertOrderAsync(Order order)
        {
            order.Id = Guid.NewGuid().ToString();
            await _applicationDbContext.Orders.AddAsync(order);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get order by Id
        public async Task<Order> GetOrderAsync(int Id)
        {
            Order order = await _applicationDbContext.Orders.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return order;
        }

        //Update order
        public async Task<bool> UpdateOrderAsync(Order order)
        {
            _applicationDbContext.Orders.Update(order);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete order
        public async Task<bool> DeleteOrderAsync(Order order)
        {
            _applicationDbContext.Remove(order);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
