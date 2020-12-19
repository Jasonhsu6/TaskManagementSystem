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
    public class TaskService : ITaskService
    {
        private readonly IAsyncRepository<Core.Entities.Task> _taskRepository;
        private readonly IAsyncRepository<TaskHistory> _taskHistoryRepository;
        public TaskService(IAsyncRepository<Core.Entities.Task> taskRepository, 
            IAsyncRepository<TaskHistory> taskHistoryRepository)
        {
            _taskHistoryRepository = taskHistoryRepository;
            _taskRepository = taskRepository;
        }

        public async Task<CompletedTaskResponseModel> AddCompletedTask(CompletedTaskRequestModel request)
        {
            var entity = new TaskHistory
            {
                TaskId = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Completed = request.Completed
            };
            var completedTask = await _taskHistoryRepository.AddAsync(entity);
            var response = new CompletedTaskResponseModel
            {
                TaskId = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Completed = request.Completed
            };
            return response;
        }

        public async Task<PendingTaskResponseModel> AddPendingTask(PendingTaskRequestModel request)
        {
            var entity = new Core.Entities.Task
            {
                Id = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Priority = request.Priority
            };
            var completedTask = await _taskRepository.AddAsync(entity);
            var response = new PendingTaskResponseModel
            {
                TaskId = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Priority = request.Priority
            };
            return response;
        }

        public async Task<CompletedTaskResponseModel> DeleteCompletedTask(CompletedTaskRequestModel request)
        {
            var entity = new TaskHistory
            {
                TaskId = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Completed = request.Completed
            };
            var completedTask = await _taskHistoryRepository.DeleteAsync(entity);
            var response = new CompletedTaskResponseModel
            {
                TaskId = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Completed = request.Completed
            };
            return response;
        }

        public async Task<PendingTaskResponseModel> DeletePendingTask(PendingTaskRequestModel request)
        {
            var entity = new Core.Entities.Task
            {
                Id = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Priority = request.Priority
            };
            var pendingTask = await _taskRepository.DeleteAsync(entity);
            var response = new PendingTaskResponseModel
            {
                TaskId = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Priority = request.Priority
            };
            return response;
        }

        public async Task<CompletedTaskResponseModel> GetCompletedTaskById(int id)
        {
            var entity = await _taskHistoryRepository.GetByIdAsync(id);
            var response = new CompletedTaskResponseModel
            {
                TaskId = entity.TaskId,
                UserId = entity.UserId,
                Title = entity.Title,
                Description = entity.Description,
                Remarks = entity.Remarks,
                DueDate = entity.DueDate,
                Completed = entity.Completed
            };
            return response;
        }

        public async Task<PendingTaskResponseModel> GetPendingTaskById(int id)
        {
            var entity = await _taskRepository.GetByIdAsync(id);
            var response = new PendingTaskResponseModel
            {
                TaskId = entity.Id,
                UserId = entity.UserId,
                Title = entity.Title,
                Description = entity.Description,
                Remarks = entity.Remarks,
                DueDate = entity.DueDate,
                Priority = entity.Priority
            };
            return response;
        }

        public async Task<IEnumerable<CompletedTaskResponseModel>> ListAllCompletedTasks()
        {
            var completedTasks = await _taskHistoryRepository.ListAllAsync();
            var response = new List<CompletedTaskResponseModel>();
            foreach(var task in completedTasks)
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
            };
            return response;
        }

        public async Task<IEnumerable<PendingTaskResponseModel>> ListAllPendingTasks()
        {
            var pendingTasks = await _taskRepository.ListAllAsync();
            var response = new List<PendingTaskResponseModel>();
            foreach (var task in pendingTasks)
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
            };
            return response;
        }

        public async Task<CompletedTaskResponseModel> UpdateCompletedTask(CompletedTaskRequestModel request)
        {
            var entity = new TaskHistory
            {
                TaskId = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Completed = request.Completed
            };
            var completedTask = await _taskHistoryRepository.UpdateAsync(entity);
            var response = new CompletedTaskResponseModel
            {
                TaskId = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Completed = request.Completed
            };
            return response;
        }

        public async Task<PendingTaskResponseModel> UpdatePendingTask(PendingTaskRequestModel request)
        {
            var entity = new Core.Entities.Task
            {
                Id = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Priority = request.Priority
            };
            var pendingTask = await _taskRepository.UpdateAsync(entity);
            var response = new PendingTaskResponseModel
            {
                TaskId = request.TaskId,
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Remarks = request.Remarks,
                DueDate = request.DueDate,
                Priority = request.Priority
            };
            return response;
        }
    }
}
