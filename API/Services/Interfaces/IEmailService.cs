namespace API.Services.Interfaces
{
    public interface IEmailService
    {
        public  Task SendEmailWithPdfAsync(string userId, string toEmail, string subject, string message);
    }
}