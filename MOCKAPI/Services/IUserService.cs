namespace MOCKAPI.Services
{
    public interface IUserService
    {
        Task<List<User>?> GetUsersAsync();
    }
}