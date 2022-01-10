using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data
{
    public class EquipmentService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EquipmentService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Get list od all Equipment
        public async Task<List<Equipment>> GetAllEquipmentAsync()
        {
            return await _applicationDbContext.Equipments.ToListAsync();
        }

        //Insert equipment
        public async Task<bool> InsertEquipmentAsync(Equipment equipment)
        {
            equipment.Id = Guid.NewGuid().ToString();
            await _applicationDbContext.Equipments.AddAsync(equipment);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get equipment by Id
        public async Task<Equipment> GetEquipmentAsync(string Id)
        {
            Equipment equipment = await _applicationDbContext.Equipments.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return equipment;
        }

        //Update equipment
        public async Task<bool> UpdateEquipmentAsync(Equipment equipment)
        {
            _applicationDbContext.Equipments.Update(equipment);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete equipment
        public async Task<bool> DeleteEquipmentAsync(Equipment equipment)
        {
            _applicationDbContext.Remove(equipment);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
