using Domain.Entities;
using Domain.Interfaces.Repositories;


namespace Application.Services
{

    public class StaffService : IBaseService<Staff>
    {
        private readonly IBaseRepository<Staff> _StaffRepository;
        private object Staff;

        public StaffService(IBaseRepository<Staff> StaffRepository)
        {
            _StaffRepository = StaffRepository;
        }

        public async Task<Staff> CreateAsync(Staff Staff, CancellationToken token = default)
        {
            return await _StaffRepository.CreateAsync(Staff, token);
        }



        public async Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
        {
            var Staff = await _StaffRepository.GetAsync(id, token);

            if (Staff == null)
                return false;

            return await _StaffRepository.DeleteAsync(Staff, token);
        }

        public async Task<IEnumerable<Staff>> GetAllAsync(CancellationToken token = default)
        {
            return await _StaffRepository.GetAllAsync(token);
        }

        public async Task<Staff> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _StaffRepository.GetAsync(id, token);
        }



        public async Task<bool> UpdateAsync(Staff Staffs, CancellationToken token = default)
        {
            var existingStaff = await GetAsync(Staffs.Id);

            if (existingStaff is null)
            {
                return false;
            }

            existingStaff.Name = Staffs.Name;
            existingStaff.Position = Staffs.Position;
            existingStaff.StudioId = Staffs.StudioId;

            return await _StaffRepository.UpdateAsync(existingStaff, token);

        }
    }
}


