using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MOCKAPI.Data
{
    public class UserRepository
    {
        private readonly HttpClient _httpClient;

        public UserRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>?> GetUsersAsync()
        {
            string apiUrl = "https://fake-json-api.mock.beeceptor.com/users";
            try
            {
                return await _httpClient.GetFromJsonAsync<List<User>>(apiUrl);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request Error: {ex.Message}");
                return null;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Null Error: {ex.Message}");
                return null;
            }
        }
    }
}