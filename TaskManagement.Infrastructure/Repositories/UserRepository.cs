using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Core.Entities;
using TaskManagement.Core.Models.Response;
using TaskManagement.Core.RepositoryInterfaces;
using TaskManagement.Infrastructure.Data;

namespace TaskManagement.Infrastructure.Repositories
{
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(TaskManagementDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<TaskHistory>> GetCompletedTasksByUser(int userId)
        {
            var completedTasks = await _dbContext.TasksHistories
                    .Where(th => th.UserId == userId)
                    .Include(u => u.User).OrderBy(th => th.Completed).ToListAsync();
            return completedTasks;
        }

        public async Task<IEnumerable<Core.Entities.Task>> GetPendingTasksByUser(int userId)
        {
            var pendingTasks = await _dbContext.Tasks
                .Where(t => t.UserId == userId)
                .Include(u => u.User).OrderBy(t => t.Priority).ToListAsync();
            return pendingTasks;
        }
    }
}
