using FC.Exercicios.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC.Exercicios.Business.Services
{
    public class TaskService : ITaskService
    {
        private readonly Dictionary<Guid, string> _tasks = new Dictionary<Guid, string>();

        public Guid RunTask(string taskType)
        {
            var taskId = Guid.NewGuid();
            // Simula a adição de uma tarefa.
            _tasks.Add(taskId, taskType);
            // Simula a execução da tarefa.
            Console.WriteLine($"Task {taskId} of type {taskType} started.");
            return taskId;
        }

        public bool CompleteTask(Guid taskId)
        {
            if (_tasks.ContainsKey(taskId))
            {
                // Simula a conclusão de uma tarefa.
                _tasks.Remove(taskId);
                Console.WriteLine($"Task {taskId} completed.");
                return true;
            }
            return false;
        }
    }
}
