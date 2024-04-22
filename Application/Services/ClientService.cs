using ConsoleApp1.Entities;
using Domain.Interfaces.Repositories;


namespace Application.Services
{
    
        public class ClientService : IBaseService<Client>
        {
            private readonly IBaseRepository<Client> _ClientRepository;
        private object Client;

        public ClientService(IBaseRepository<Client> clientRepository)
            {
            _ClientRepository = clientRepository;
            }

            public async Task<Client> CreateAsync(Client client, CancellationToken token = default)
            {
                return await _ClientRepository.CreateAsync(client, token);
            }



        public async Task<bool> DeleteAsync(Guid id, CancellationToken token = default)
        {
            var client = await _ClientRepository.GetAsync(id, token);

            if (client == null)
                return false;

            return await _ClientRepository.DeleteAsync(client, token);
        }

        public async Task<IEnumerable<Client>> GetAllAsync(CancellationToken token = default)
            {
                return await _ClientRepository.GetAllAsync(token);
            }

            public async Task<Client> GetAsync(Guid id, CancellationToken token = default)
            {
                return await _ClientRepository.GetAsync(id, token);
            }



        public async Task<bool> UpdateAsync(Client clients, CancellationToken token = default)
            {
                var existingClient = await GetAsync(clients.Id);

                if (existingClient is null)
                {
                    return false;
                }

            existingClient.Name = clients.Name;
            existingClient.Phone = clients.Phone;
            existingClient.Email = clients.Email;

            return await _ClientRepository.UpdateAsync(existingClient, token);

            }
        }
    }


