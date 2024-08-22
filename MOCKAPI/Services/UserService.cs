using MOCKAPI.Data;
using MOCKAPI.Interfaces;

namespace MOCKAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>?> GetUsersAsync()
        {
            List<User>? users = await _userRepository.GetUsersAsync() ?? throw new ArgumentException("No Users Found");

            return users;
        }
    }
}