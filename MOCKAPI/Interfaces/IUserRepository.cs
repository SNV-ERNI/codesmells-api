namespace MOCKAPI.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>?> GetUsersAsync();
    }
}