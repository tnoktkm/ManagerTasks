using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class DbTaskRepository : ITaskRepository
{
    private readonly ApplicationDbContext _context;

    public DbTaskRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<TaskItem> GetAll() => _context.TaskItems.ToList();

    public TaskItem GetById(int id) => _context.TaskItems.Find(id);

    public void Add(TaskItem task)
    {
        _context.TaskItems.Add(task);
        _context.SaveChanges();
    }

    public void Update(TaskItem task)
    {
        _context.TaskItems.Update(task);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var task = _context.TaskItems.Find(id);
        if (task != null)
        {
            _context.TaskItems.Remove(task);
            _context.SaveChanges();
        }
    }
}