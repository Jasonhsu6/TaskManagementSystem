using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities;
using System.Threading.Tasks;
using TaskManagement.Core.Models.Response;

namespace TaskManagement.Core.ServiceInterfaces
{
    public interface IUserService
    {
        Task<IEnumerable<TaskResponseModel>> GetTasksByUser();
    }
}
