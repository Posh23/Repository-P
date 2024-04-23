using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EquipmentService : IBaseService<Equipment>
    {
        private readonly IBaseRepository<Equipment> _EquipmentRepository;
        private object Equipment;

        public EquipmentService(IBaseRepository<Equipment> EquipmentRepository)
        {
            _EquipmentRepository = EquipmentRepository;
        }

        public async Task<Equipment> CreateAsync(Equipment Equipment, CancellationToken token = default)
        {
            return await _EquipmentRepository.CreateAsync(Equipment, token);
        }



        public async Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
        {
            var Equipment = await _EquipmentRepository.GetAsync(id, token);

            if (Equipment == null)
                return false;

            return await _EquipmentRepository.DeleteAsync(Equipment, token);
        }

        public async Task<IEnumerable<Equipment>> GetAllAsync(CancellationToken token = default)
        {
            return await _EquipmentRepository.GetAllAsync(token);
        }

        public async Task<Equipment> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _EquipmentRepository.GetAsync(id, token);
        }



        public async Task<bool> UpdateAsync(Equipment Equipments, CancellationToken token = default)
        {
            var existingEquipment = await GetAsync(Equipments.Id);

            if (existingEquipment is null)
            {
                return false;
            }

            existingEquipment.Type = Equipments.Type;
            existingEquipment.Brand = Equipments.Brand;
            existingEquipment.Condition = Equipments.Condition;
            existingEquipment.Availability = Equipments.Availability;

            return await _EquipmentRepository.UpdateAsync(existingEquipment, token);

        }
    }
}
