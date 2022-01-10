using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data
{
    public class LocationService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public LocationService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get list of all locations
        public async Task<List<Location>> GetAllLocationsAsync()
        {
            return await _applicationDbContext.Locations.ToListAsync();
        }

        //Insert location
        public async Task<bool> InsertLocationAsync(Location location)
        {
            location.Id = Guid.NewGuid().ToString();
            await _applicationDbContext.Locations.AddAsync(location);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get location by Id
        public async Task<Location> GetLocationAsync(string Id)
        {
            Location location = await _applicationDbContext.Locations.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return location;
        }

        //Update location
        public async Task<bool> UpdateLocationAsync(Location location)
        {
            _applicationDbContext.Locations.Update(location);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete location
        public async Task<bool> DeleteLocationAsync(Location location)
        {
            _applicationDbContext.Remove(location);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
