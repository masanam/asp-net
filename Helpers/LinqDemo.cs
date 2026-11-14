
using System.Linq;

namespace TaskManagerAPI.Helpers;

public static class LinqDemo
{
    public static void Run()
    {
        // Example LINQ operations
        var tasks = new List<dynamic>();

        var activeTasks = tasks
            .Where(t => !t.IsCompleted);

        var grouped = tasks
            .GroupBy(t => t.UserId);
    }
}
