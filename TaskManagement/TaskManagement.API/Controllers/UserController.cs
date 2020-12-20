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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.ListAllUsers();
            if (users == null)
            {
                return NotFound("Users not found");
            }
            return Ok(users);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound("User not found");
            }
            return Ok(user);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddUser(UserRequestModel request)
        {
            var user = await _userService.AddUser(request);
            if (user == null)
            {
                return BadRequest("Add failed");
            }
            return Ok(user);
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateUser(UserRequestModel request)
        {
            var user = await _userService.UpdateUser(request);
            return Ok(user);
        }

        [HttpDelete]
        [Route("")]
        public async Task<IActionResult> DeleteUser(UserRequestModel request)
        {
            var user = await _userService.DeleteUser(request);
            return Ok(user);
        }

        [HttpGet]
        [Route("{userId:int}/pending")]
        public async Task<IActionResult> GetPendingTaskByUserId(int userId)
        {
            var tasks = await _userService.GetPendingTasksByUser(userId);
            return Ok(tasks);
        }
        [HttpGet]
        [Route("{userId:int}/completed")]
        public async Task<IActionResult> GetCompletedTaskByUserId(int userId)
        {
            var tasks = await _userService.GetCompletedTasksByUser(userId);
            return Ok(tasks);
        }
    }
}
