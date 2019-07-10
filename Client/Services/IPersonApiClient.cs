
using Client.Model;
using System.Collections.Generic;
using WebApiClient;
using WebApiClient.Attributes;
using System.Threading.Tasks;
using Client.ApiInterface;

namespace Client.Services
{

    public interface IPersonApiService
    {

        Task<List<Person>> GetAllPersonsAsync();

    }
    public class PersonApiService : IPersonApiService
    {
        private readonly IPersonApiClient _personApiClient;
        public PersonApiService(IPersonApiClient personApiClient)
        {
            _personApiClient = personApiClient;
        }

        public async Task<List<Person>> GetAllPersonsAsync()
        {
            return await _personApiClient.GetPersonsAsync();
        }
    }
}
