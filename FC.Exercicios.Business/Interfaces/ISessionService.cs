using FC.Exercicios.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC.Exercicios.Business.Interfaces
{
    public interface ISessionService
    {
        UserSession StartSession(string userId);
        UserSession UpdateSession(Guid sessionId);
        void EndSession(Guid sessionId);
    }
}