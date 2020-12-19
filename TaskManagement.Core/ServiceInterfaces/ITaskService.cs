using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Models.Request;
using TaskManagement.Core.Models.Response;

namespace TaskManagement.Core.ServiceInterfaces
{
    public interface ITaskService
    {
        // CRUD operations for pending tasks
        Task<PendingTaskResponseModel> AddPendingTask(PendingTaskRequestModel request);
        Task<PendingTaskResponseModel> UpdatePendingTask(PendingTaskRequestModel request);
        Task<PendingTaskResponseModel> GetPendingTaskById(int id);
        Task<IEnumerable<PendingTaskResponseModel>> ListAllPendingTasks();
        Task<PendingTaskResponseModel> DeletePendingTask(PendingTaskRequestModel request);

        // CRUD operations for completed tasks
        Task<CompletedTaskResponseModel> AddCompletedTask(CompletedTaskRequestModel request);
        Task<CompletedTaskResponseModel> UpdateCompletedTask(CompletedTaskRequestModel request);
        Task<CompletedTaskResponseModel> GetCompletedTaskById(int id);
        Task<IEnumerable<CompletedTaskResponseModel>> ListAllCompletedTasks();
        Task<CompletedTaskResponseModel> DeleteCompletedTask(CompletedTaskRequestModel request);
    }
}
