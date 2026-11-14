namespace TaskManagerAPI.DTOs;

public record DashboardSummaryDto(
    string Name,
    int TotalTasks,
    int CompletedTasks
);