using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Core.Models.Request;
using TaskManagement.Core.ServiceInterfaces;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        //pending tasks api
        [HttpGet]
        [Route("pending")]
        public async Task<IActionResult> GetAllPendingTasks()
        {
            var pendingTasks = await _taskService.ListAllPendingTasks();
            if (pendingTasks == null)
            {
                return NotFound("Tasks not found");
            }
            return Ok(pendingTasks);
        }
        [HttpGet]
        [Route("pending/{id:int}")]
        public async Task<IActionResult> GetPendingTaskById(int id)
        {
            var pendingTasks = await _taskService.GetPendingTaskById(id);
            if (pendingTasks == null)
            {
                return NotFound("Task not found");
            }
            return Ok(pendingTasks);
        }
        [HttpPost]
        [Route("pending")]
        public async Task<IActionResult> AddPendingTask(PendingTaskRequestModel request)
        {
            var pendingTask = await _taskService.AddPendingTask(request);
            if (pendingTask == null)
            {
                return BadRequest("Add failed");
            }
            return Ok(pendingTask);
        }
        [HttpPut]
        [Route("pending")]
        public async Task<IActionResult> UpdatePendingTasks(PendingTaskRequestModel request)
        {
            var pendingTask = await _taskService.UpdatePendingTask(request);
            return Ok(pendingTask);
        }
        [HttpDelete]
        [Route("pending")]
        public async Task<IActionResult> DeletePendingTasks(PendingTaskRequestModel request)
        {
            var pendingTasks = await _taskService.DeletePendingTask(request);
            return Ok(pendingTasks);
        }

        // completed tasks api
        [HttpGet]
        [Route("completed")]
        public async Task<IActionResult> GetAllCompletedTasks()
        {
            var completedTasks = await _taskService.ListAllCompletedTasks();
            if (completedTasks == null)
            {
                return NotFound("Tasks not found");
            }
            return Ok(completedTasks);
        }
        [HttpGet]
        [Route("completed/{id:int}")]
        public async Task<IActionResult> GetCompletedTaskById(int id)
        {
            var completedTasks = await _taskService.GetCompletedTaskById(id);
            if (completedTasks == null)
            {
                return NotFound("Task not found");
            }
            return Ok(completedTasks);
        }
        [HttpPost]
        [Route("completed")]
        public async Task<IActionResult> AddCompletedTask(CompletedTaskRequestModel request)
        {
            var completedTask = await _taskService.AddCompletedTask(request);
            if (completedTask == null)
            {
                return BadRequest("Add failed");
            }
            return Ok(completedTask);
        }
        [HttpPut]
        [Route("completed")]
        public async Task<IActionResult> UpdateCompletedTask(CompletedTaskRequestModel request)
        {
            var completedTask = await _taskService.UpdateCompletedTask(request);
            return Ok(completedTask);
        }
        [HttpDelete]
        [Route("completed")]
        public async Task<IActionResult> DeleteCompletedTasks(CompletedTaskRequestModel request)
        {
            var completedTasks = await _taskService.DeleteCompletedTask(request);
            return Ok(completedTasks);
        }

    }
}
