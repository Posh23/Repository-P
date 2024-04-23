using Domain.Entities;
using Domain.Interfaces.Repositories;


namespace Application.Services
{

    public class PhotographerService : IBaseService<Photographer>
    {
        private readonly IBaseRepository<Photographer> _PhotographerRepository;
        private object Photographer;

        public PhotographerService(IBaseRepository<Photographer> PhotographerRepository)
        {
            _PhotographerRepository = PhotographerRepository;
        }

        public async Task<Photographer> CreateAsync(Photographer Photographer, CancellationToken token = default)
        {
            return await _PhotographerRepository.CreateAsync(Photographer, token);
        }



        public async Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
        {
            var Photographer = await _PhotographerRepository.GetAsync(id, token);

            if (Photographer == null)
                return false;

            return await _PhotographerRepository.DeleteAsync(Photographer, token);
        }

        public async Task<IEnumerable<Photographer>> GetAllAsync(CancellationToken token = default)
        {
            return await _PhotographerRepository.GetAllAsync(token);
        }

        public async Task<Photographer> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _PhotographerRepository.GetAsync(id, token);
        }



        public async Task<bool> UpdateAsync(Photographer Photographers, CancellationToken token = default)
        {
            var existingPhotographer = await GetAsync(Photographers.Id);

            if (existingPhotographer is null)
            {
                return false;
            }

            existingPhotographer.Name = Photographers.Name;
            existingPhotographer.Age = Photographers.Age;
            existingPhotographer.Specialty = Photographers.Specialty;
            existingPhotographer.PhotoSessionId = Photographers.PhotoSessionId;

            return await _PhotographerRepository.UpdateAsync(existingPhotographer, token);

        }
    }
}


