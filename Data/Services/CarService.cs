using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektInzynierskiBlazor.Data.Entities;

namespace ProjektInzynierskiBlazor.Data.Services
{
    public class CarService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CarService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get list of all cars
        public async Task<List<Car>> GetAllCarsAsync()
        {
            return await _applicationDbContext.Cars.ToListAsync();
        }

        //Insert car
        public async Task<bool> InsertCarAsync(Car car)
        {
            car.Id = Guid.NewGuid().ToString();
            await _applicationDbContext.Cars.AddAsync(car);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get car by Id
        public async Task<Car> GetCarAsync(string Id)
        {
            Car car = await _applicationDbContext.Cars.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return car;
        }

        //Update car
        public async Task<bool> UpdateCarAsync(Car car)
        {
            _applicationDbContext.Cars.Update(car);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete car
        public async Task<bool> DeleteCarAsync(Car car)
        {
            _applicationDbContext.Remove(car);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
