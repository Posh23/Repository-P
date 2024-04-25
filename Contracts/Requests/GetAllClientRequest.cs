

using Domain.Entities;

namespace Contracts.Requests
{
    public class GetAllClientRequest
    {
        public IEnumerable<Client> Items { get; set; } = Enumerable.Empty<Client>();

    }
}
