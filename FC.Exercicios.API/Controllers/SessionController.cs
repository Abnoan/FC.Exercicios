using FC.Exercicios.Business.Interfaces;
using FC.Exercicios.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace FC.Exercicios.API.Controllers
{
    [ApiController]
    [Route("api/session")]
    public class SessionController : ControllerBase
    {
        private readonly ISessionService _sessionService;
        public SessionController(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        [HttpPost("StartSession")]
        public ActionResult<UserSession> StartSession([FromBody] string userId)
        {
            var session = _sessionService.StartSession(userId);
            return Ok(session);
        }

        [HttpPost("UpdateSession")]
        public ActionResult<UserSession> UpdateSession([FromBody] UserSession session)
        {
            var session2 = _sessionService.UpdateSession(session.SessionId);
            return session is not null ? Ok(session) : NotFound("Sessão não encontrada!");
        }

        [HttpPost("EndSession")]
        public ActionResult<UserSession> EndSession([FromBody] Guid sessionId)
        {
            _sessionService.EndSession(sessionId);
            return Ok("Sessão Terminada");
        }
    }
}
