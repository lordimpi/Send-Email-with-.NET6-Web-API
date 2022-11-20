using SampleEmailApp.Models;

namespace SampleEmailApp.Service.EmailService
{
    public interface IEmailService
    {
        Task SendEmail(EmailDTO request);
    }
}
