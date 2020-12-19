using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Entities;
using TaskManagement.Core.Models.Response;

namespace TaskManagement.Core.RepositoryInterfaces
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<IEnumerable<Entities.Task>> GetPendingTasksByUser(int userId);
        Task<IEnumerable<TaskHistory>> GetCompletedTasksByUser(int userId);
    }
}
