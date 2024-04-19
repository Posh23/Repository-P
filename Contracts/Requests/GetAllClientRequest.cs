using ConsoleApp1.Entities;

namespace Contracts.Requests
{
    public class GetAllBuildingsRequest
    {
        public IEnumerable<Client> Items { get; set; } = Enumerable.Empty<Client>();

    }
}
