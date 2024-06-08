using FC.Exercicios.Business.Interfaces;
using FC.Exercicios.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC.Exercicios.Business.Services
{
    public class SessionService : ISessionService
    {
        private readonly List<UserSession> _sessions = new List<UserSession>();

        public UserSession StartSession(string userId)
        {
            var session = new UserSession();
            session.SessionId = Guid.NewGuid();
            session.UserId = userId;
            session.StartTime = DateTime.Now;

            _sessions.Add(session);
            return session;
        }    

        public UserSession UpdateSession(Guid sessionId)
        {
            var session = _sessions.FirstOrDefault(session => session.SessionId == sessionId);
            if (session is not null && session.EndTime == null)
            {
                session.StartTime = DateTime.Now;
            }

            return session;
        }

        public void EndSession(Guid sessionId)
        {
            var session = _sessions.FirstOrDefault(session => session.SessionId == sessionId);
            if (session is not null)
            {
                session.EndTime = DateTime.Now;
            }
        }
    }
}
