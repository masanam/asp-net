
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(int userId);
}
