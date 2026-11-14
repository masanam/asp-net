using System.ComponentModel;
using System.Reflection;
using Microsoft.VisualBasic;
using TaskManagerAPI.DTOs;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Extensions;

public static class TaskExtensions
{
    public static TaskResponseDto ToDto(this TaskItem task) =>
        new(task.Id, task.Title, task.Description, task.IsCompleted, task.CreatedAt, 
            task.DueDate, task.AttachmentPath);

    public static TaskItem ToModel(this CreateTaskDto dto, int userId) =>
    new()
    {
        Title = dto.Title,
        Description = dto.Description ?? string.Empty,
        DueDate = dto.DueDate,
        UserId = userId
    };
}

