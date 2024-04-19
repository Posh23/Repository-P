

using ConsoleApp1.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class ClientService : IBaseRepository<Client>
    {
        private readonly IBaseRepository<Client> _clientRepository;

        public ClientService(IBaseRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client> CreateAsync(Client client, CancellationToken token = default)
        {
            return await _clientRepository.CreateAsync(client, token);
        }

        public async Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
        {
            var client = await _clientRepository.GetAsync(id);

            if (client == null)
                return false;

            return await _clientRepository.DeleteAsync(client, token);
        }

        public Task<bool> DeleteAsync(Client entity, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Client>> GetAllAsync(CancellationToken token = default)
        {
            return await _clientRepository.GetAllAsync(token);
        }

        public async Task<Client> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _clientRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Client client, CancellationToken token = default)
        {
            var existingClient = await GetAsync(client.Id);

            if (existingClient is null)
            {
                return false;
            }

            existingClient.Name = client.Name;
            existingClient.Phone = client.Phone;
            existingClient.Email = client.Email;

            return await _clientRepository.UpdateAsync(existingClient, token);
        }
    }
}