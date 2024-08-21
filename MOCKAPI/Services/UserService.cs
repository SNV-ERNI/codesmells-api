using System.Collections.Generic;
using System.Threading.Tasks;
using MOCKAPI.Data;

namespace MOCKAPI.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>?> GetUsersAsync()
        {
            return await _userRepository.GetUsersAsync();
        }
    }
}