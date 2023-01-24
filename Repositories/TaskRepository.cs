using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TodoContext _context;
        public TaskRepository(TodoContext context)
        {
            _context = context;
        }
        public TaskModel Get(int taskId)
            => _context.Task.SingleOrDefault(x => x.TaskId == taskId);

        public IQueryable<TaskModel> GetAllActive()
            => _context.Task.Where(x => !x.TaskDone);

        public void Add(TaskModel task)
        {
            _context.Task.Add(task);
            _context.SaveChanges();
        }

        public void Update(int taskId, TaskModel task)
        {
            var result = _context.Task.SingleOrDefault(x => x.TaskId == taskId);
            if (result != null)
            {
                result.TaskName = task.TaskName;
                result.TaskDesc = task.TaskDesc;
                result.TaskDone = task.TaskDone;

                _context.SaveChanges();
            }
        }

        public void Delete(int taskId)
        {
            var result = _context.Task.SingleOrDefault(x => x.TaskId == taskId);
            if (result != null)
            {
                _context.Task.Remove(result);
                _context.SaveChanges();
            }
        }

    }
}
