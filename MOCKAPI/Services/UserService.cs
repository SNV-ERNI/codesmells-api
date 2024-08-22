using MOCKAPI.Data;

namespace MOCKAPI.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>?> GetUsersAsync()
        {
            List<User>? users = await _userRepository.GetUsersAsync() ?? throw new ArgumentException("No Users Found");
            foreach (var user in users)
            {
                user.name += " :";
            }
            return users;
        }
    }
}