using TaskManagerAPI.Interfaces;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Repositories;

public class UserRepository : IUserRepository
{
    public async Task<User?> GetByIdAsync(int userId)
    {
        // Temporary example data
        await Task.Delay(100);

        return new User
        {
            Id = userId,
            Name = "Demo User",
            Email = "demo@example.com"
        };
    }
}