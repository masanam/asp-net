using TaskManagerAPI.Models;

namespace TaskManagerAPI.Interfaces;

public interface ITaskRepository
{
    Task<IEnumerable<TaskItem>> GetAllByUserAsync(int userId);
    Task<TaskItem?> GetByIdAsync(int id, int userId);
    Task<TaskItem> CreateAsync(TaskItem task);
    Task UpdateAsync(TaskItem task);
    Task<bool> DeleteAsync(int id, int userId);
    Task<bool> ExistsAsync(int id);
}

