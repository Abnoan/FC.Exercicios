namespace FC.Exercicios.Business.Models
{
    public class UserSession
    {
        public Guid SessionId { get; set; }
        public string UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
