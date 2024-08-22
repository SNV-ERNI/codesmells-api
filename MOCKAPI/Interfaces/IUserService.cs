namespace MOCKAPI.Interfaces
{
    public interface IUserService
    {
        Task<List<User>?> GetUsersAsync();
    }
}