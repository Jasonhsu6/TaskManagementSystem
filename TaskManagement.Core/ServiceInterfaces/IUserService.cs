using System;
using System.Collections.Generic;
using System.Text;
using TaskManagement.Core.Entities;
using System.Threading.Tasks;
using TaskManagement.Core.Models.Response;
using TaskManagement.Core.Models.Request;

namespace TaskManagement.Core.ServiceInterfaces
{
    public interface IUserService
    {
        Task<IEnumerable<PendingTaskResponseModel>> GetPendingTasksByUser(int userId);
        Task<IEnumerable<CompletedTaskResponseModel>> GetCompletedTasksByUser(int userId);

        Task<UserResponseModel> AddUser(UserRequestModel request);
        Task<UserResponseModel> GetUserById(int id);
        Task<IEnumerable<UserResponseModel>> ListAllUsers();
        Task<UserResponseModel> UpdateUser(UserRequestModel request);
        Task<UserResponseModel> DeleteUser(UserRequestModel request);
    }
}
