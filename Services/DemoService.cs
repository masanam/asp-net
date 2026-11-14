using TaskManagerAPI.DTOs;
using TaskManagerAPI.Interfaces;

namespace TaskManagerAPI.Services;

public class DemoService
{
    private readonly ITaskRepository _repo;
    private readonly IUserRepository _userRepo;

    public DemoService(
        ITaskRepository repo,
        IUserRepository userRepo)
    {
        _repo = repo;
        _userRepo = userRepo;
    }

    public async Task<DashboardSummaryDto> GetDashboardAsync(int userId)
    {
        // Execute both queries in parallel
        var tasksTask = _repo.GetAllByUserAsync(userId);
        var userTask = _userRepo.GetByIdAsync(userId);

        await Task.WhenAll(tasksTask, userTask);

        var tasks = await tasksTask;
        var user = await userTask;

        if (user == null)
            throw new Exception("User not found");

        return new DashboardSummaryDto(
            user.Name,
            tasks.Count(),
            tasks.Count(t => t.IsCompleted)
        );
    }
}
