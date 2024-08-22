using System;
using System.Net.Http;
using System.Threading.Tasks;
using MOCKAPI.Services;
using MOCKAPI.Data;

namespace MOCKAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                UserRepository userRepository = new(client);
                UserService userService = new(userRepository);

                List<User>? users = await userService.GetUsersAsync();

                if (users != null)
                {
                    foreach (var user in users)
                    {
                        Console.WriteLine($"ID: {user.id}. Name: {user.name} Email: {user.email}");
                    }
                }
                else
                {
                    Console.WriteLine("No Users Found.");
                }
            }
        }
    }
}