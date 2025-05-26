using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskModel>> GetAllAsync();
        Task<TaskModel> GetByIdAsync(Guid id);
        Task CreateAsync(TaskModel task);
        Task UpdateAsync(TaskModel task);
        Task DeleteAsync(Guid id);
    }
}
