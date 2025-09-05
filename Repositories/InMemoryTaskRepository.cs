public class InMemoryTaskRepository : ITaskRepository
{
    private readonly List<TaskItem> _tasks = new();

    public IEnumerable<TaskItem> GetAll() => _tasks;
    public TaskItem GetById(int id) => _tasks.FirstOrDefault(t => t.Id == id);
    public void Add(TaskItem task) => _tasks.Add(task);
    public void Update(TaskItem task)
    {
        var existing = GetById(task.Id);
        if (existing != null)
        {
            existing.Title = task.Title;
            existing.Description = task.Description;
            existing.IsCompleted = task.IsCompleted;
        }
    }
    public void Delete(int id) => _tasks.RemoveAll(t => t.Id == id);
}