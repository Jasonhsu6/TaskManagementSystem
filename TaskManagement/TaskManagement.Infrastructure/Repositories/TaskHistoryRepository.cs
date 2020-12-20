using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities;
using TaskManagement.Infrastructure.Data;

namespace TaskManagement.Infrastructure.Repositories
{
    public class TaskHistoryRepository : EfRepository<TaskHistory>
    {
        public TaskHistoryRepository(TaskManagementDbContext dbContext) : base(dbContext)
        {

        }
    }
}
