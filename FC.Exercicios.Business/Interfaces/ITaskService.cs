using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC.Exercicios.Business.Interfaces
{
    public interface ITaskService
    {
        Guid RunTask(string taskType);
        bool CompleteTask(Guid taskId);
    }
}
