public class TaskService : ITaskService
{
    private readonly ITaskRepository _repository;

    public TaskService(ITaskRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<TaskItem> GetAllTasks() => _repository.GetAll();
    public TaskItem GetTask(int id) => _repository.GetById(id);
    public void CreateTask(TaskItem task) => _repository.Add(task);
    public void UpdateTask(TaskItem task) => _repository.Update(task);
    public void DeleteTask(int id) => _repository.Delete(id);
}