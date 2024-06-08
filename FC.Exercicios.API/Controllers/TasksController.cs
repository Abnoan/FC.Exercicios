using FC.Exercicios.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FC.Exercicios.API.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost("run")]
        public ActionResult<Guid> RunTask([FromBody] string taskType)
        {
            var taskId = _taskService.RunTask(taskType);
            return Ok(taskId);
        }

        [HttpPost("complete")]
        public ActionResult CompleteTask([FromBody] Guid taskId)
        {
            var result = _taskService.CompleteTask(taskId);
            if (result)
                return Ok("Task completed successfully.");
            else
                return NotFound("Task not found.");
        }

    }
}