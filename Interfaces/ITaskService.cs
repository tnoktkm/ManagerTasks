public interface ITaskService
{
    IEnumerable<TaskItem> GetAllTasks();
    TaskItem GetTask(int id);
    void CreateTask(TaskItem task);
    void UpdateTask(TaskItem task);
    void DeleteTask(int id);
}