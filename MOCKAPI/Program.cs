﻿using MOCKAPI.Services;
using MOCKAPI.Data;
using MOCKAPI.Interfaces;

namespace MOCKAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IUserRepository userRepository = new UserRepository();

            List<User>? users = await new UserService(userRepository).GetUsersAsync();

            if (users != null)
            {
                //you could also include other properties in the foreach Loop(e.g. username, company, etc.).
                foreach (var user in users)
                {
                    Console.WriteLine($"ID: {user.id} | Name: {user.name} | Email: {user.email}");
                }
            }
            else
            {
                Console.WriteLine("No Users Found.");
            }

        }
    }
}