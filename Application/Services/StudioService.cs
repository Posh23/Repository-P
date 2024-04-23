using Domain.Entities;
using Domain.Interfaces.Repositories;


namespace Application.Services
{

    public class StudioService : IBaseService<Studio>
    {
        private readonly IBaseRepository<Studio> _StudioRepository;
        private object Studio;

        public StudioService(IBaseRepository<Studio> StudioRepository)
        {
            _StudioRepository = StudioRepository;
        }

        public async Task<Studio> CreateAsync(Studio Studio, CancellationToken token = default)
        {
            return await _StudioRepository.CreateAsync(Studio, token);
        }



        public async Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
        {
            var Studio = await _StudioRepository.GetAsync(id, token);

            if (Studio == null)
                return false;

            return await _StudioRepository.DeleteAsync(Studio, token);
        }

        public async Task<IEnumerable<Studio>> GetAllAsync(CancellationToken token = default)
        {
            return await _StudioRepository.GetAllAsync(token);
        }

        public async Task<Studio> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _StudioRepository.GetAsync(id, token);
        }



        public async Task<bool> UpdateAsync(Studio Studios, CancellationToken token = default)
        {
            var existingStudio = await GetAsync(Studios.Id);

            if (existingStudio is null)
            {
                return false;
            }

            existingStudio.Name = Studios.Name;
            existingStudio.Address = Studios.Address;
            existingStudio.EquipmentId = Studios.EquipmentId;

            return await _StudioRepository.UpdateAsync(existingStudio, token);

        }
    }
}


