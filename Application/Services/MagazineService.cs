using Domain.Entities;
using Domain.Interfaces.Repositories;


namespace Application.Services
{

    public class MagazineService : IBaseService<Magazine>
    {
        private readonly IBaseRepository<Magazine> _MagazineRepository;
        private object Magazine;

        public MagazineService(IBaseRepository<Magazine> MagazineRepository)
        {
            _MagazineRepository = MagazineRepository;
        }

        public async Task<Magazine> CreateAsync(Magazine Magazine, CancellationToken token = default)
        {
            return await _MagazineRepository.CreateAsync(Magazine, token);
        }



        public async Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
        {
            var Magazine = await _MagazineRepository.GetAsync(id, token);

            if (Magazine == null)
                return false;

            return await _MagazineRepository.DeleteAsync(Magazine, token);
        }

        public async Task<IEnumerable<Magazine>> GetAllAsync(CancellationToken token = default)
        {
            return await _MagazineRepository.GetAllAsync(token);
        }

        public async Task<Magazine> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _MagazineRepository.GetAsync(id, token);
        }



        public async Task<bool> UpdateAsync(Magazine Magazines, CancellationToken token = default)
        {
            var existingMagazine = await GetAsync(Magazines.Id);

            if (existingMagazine is null)
            {
                return false;
            }

            existingMagazine.Name = Magazines.Name;
            existingMagazine.Type = Magazines.Type;
            existingMagazine.PhotoSessionId = Magazines.PhotoSessionId;
            existingMagazine.EquipmentId = Magazines.EquipmentId;

            return await _MagazineRepository.UpdateAsync(existingMagazine, token);

        }
    }
}



