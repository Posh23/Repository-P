using Domain.Entities;
using Domain.Interfaces.Repositories;


namespace Application.Services
{

    public class PhotoSessionService : IBaseService<PhotoSession>
    {
        private readonly IBaseRepository<PhotoSession> _PhotoSessionRepository;
        private object PhotoSession;

        public PhotoSessionService(IBaseRepository<PhotoSession> PhotoSessionRepository)
        {
            _PhotoSessionRepository = PhotoSessionRepository;
        }

        public async Task<PhotoSession> CreateAsync(PhotoSession PhotoSession, CancellationToken token = default)
        {
            return await _PhotoSessionRepository.CreateAsync(PhotoSession, token);
        }



        public async Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
        {
            var PhotoSession = await _PhotoSessionRepository.GetAsync(id, token);

            if (PhotoSession == null)
                return false;

            return await _PhotoSessionRepository.DeleteAsync(PhotoSession, token);
        }

        public async Task<IEnumerable<PhotoSession>> GetAllAsync(CancellationToken token = default)
        {
            return await _PhotoSessionRepository.GetAllAsync(token);
        }

        public async Task<PhotoSession> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _PhotoSessionRepository.GetAsync(id, token);
        }



        public async Task<bool> UpdateAsync(PhotoSession PhotoSessions, CancellationToken token = default)
        {
            var existingPhotoSession = await GetAsync(PhotoSessions.Id);

            if (existingPhotoSession is null)
            {
                return false;
            }

            existingPhotoSession.Duration = PhotoSessions.Duration;
            existingPhotoSession.Date = PhotoSessions.Date;

            return await _PhotoSessionRepository.UpdateAsync(existingPhotoSession, token);

        }
    }
}


