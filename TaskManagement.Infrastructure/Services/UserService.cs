using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Entities;
using TaskManagement.Core.Models.Request;
using TaskManagement.Core.Models.Response;
using TaskManagement.Core.RepositoryInterfaces;
using TaskManagement.Core.ServiceInterfaces;

namespace TaskManagement.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserResponseModel> AddUser(UserRequestModel request)
        {
            var user = new User
            {
                Id = request.Id,
                Email = request.Email,
                Password = request.Password,
                Fullname = request.FullName,
                Mobileno = request.Phone
            };
            var obj = await _repository.AddAsync(user);
            var response = new UserResponseModel
            {
                Id = obj.Id,
                Email = obj.Email,
                Password = obj.Password,
                FullName = obj.Fullname,
                Phone = obj.Mobileno
            };
            return response;
        }

        public async Task<UserResponseModel> DeleteUser(UserRequestModel request)
        {
            var user = new User
            {
                Id = request.Id,
                Email = request.Email,
                Password = request.Password,
                Fullname = request.FullName,
                Mobileno = request.Phone
            };
            await _repository.DeleteAsync(user);
            var response = new UserResponseModel
            {
                Id = request.Id,
                Email = request.Email,
                Password = request.Password,
                FullName = request.FullName,
                Phone = request.Phone
            };
            return response;
        }

        public async Task<IEnumerable<CompletedTaskResponseModel>> GetCompletedTasksByUser(int userId)
        {
            var pendingTasks = await _repository.GetCompletedTasksByUser(userId);
            var response = new List<CompletedTaskResponseModel>();
            foreach(var task in pendingTasks)
            {
                response.Add(new CompletedTaskResponseModel
                {
                    TaskId = task.TaskId,
                    UserId = task.UserId,
                    Title = task.Title,
                    Description = task.Description,
                    Remarks = task.Remarks,
                    DueDate = task.DueDate,
                    Completed = task.Completed
                });
            }
            return response;
        }

        public async Task<IEnumerable<PendingTaskResponseModel>> GetPendingTasksByUser(int userId)
        {
            var completedTasks = await _repository.GetPendingTasksByUser(userId);
            var response = new List<PendingTaskResponseModel>();
            foreach (var task in completedTasks)
            {
                response.Add(new PendingTaskResponseModel
                {
                    TaskId = task.Id,
                    UserId = task.UserId,
                    Title = task.Title,
                    Description = task.Description,
                    Remarks = task.Remarks,
                    DueDate = task.DueDate,
                    Priority = task.Priority
                });
            }
            return response;
        }

        public async Task<UserResponseModel> GetUserById(int id)
        {
            var user = await _repository.GetByIdAsync(id);
            var response = new UserResponseModel
            {
                Id = user.Id,
                Email = user.Email,
                Password = user.Password,
                FullName = user.Fullname,
                Phone = user.Mobileno
            };
            return response;
        }

        public async Task<IEnumerable<UserResponseModel>> ListAllUsers()
        {
            var users = await _repository.ListAllAsync();
            var response = new List<UserResponseModel>();
            foreach (var user in users)
            {
                response.Add(new UserResponseModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    Password = user.Password,
                    FullName = user.Fullname,
                    Phone = user.Mobileno
                });
            }
            return response;
        }

        public async Task<UserResponseModel> UpdateUser(UserRequestModel request)
        {
            var user = new User
            {
                Id = request.Id,
                Email = request.Email,
                Password = request.Password,
                Fullname = request.FullName,
                Mobileno = request.Phone
            };
            await _repository.UpdateAsync(user);
            var response = new UserResponseModel
            {
                Id = request.Id,
                Email = request.Email,
                Password = request.Password,
                FullName = request.FullName,
                Phone = request.Phone
            };
            return response;
        }
    }
}
