using Domain.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaskModel>> GetAllAsync() => await Task.FromResult(_context.Tasks.ToList());

        public async Task<TaskModel> GetByIdAsync(Guid id) => await Task.FromResult(_context.Tasks.Find(id));

        public Task CreateAsync(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }


        public Task UpdateAsync(TaskModel task)
        {
            throw new NotImplementedException();
        }
    }
}
