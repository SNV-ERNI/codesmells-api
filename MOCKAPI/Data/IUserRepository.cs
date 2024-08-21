namespace MOCKAPI.Data
{
    public interface IUserRepository
    {
        Task<List<User>?> GetUsersAsync();
    }
}