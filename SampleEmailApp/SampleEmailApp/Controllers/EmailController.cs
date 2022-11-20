using Microsoft.AspNetCore.Mvc;
using SampleEmailApp.Models;
using SampleEmailApp.Service.EmailService;

namespace SampleEmailApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(EmailDTO body)
        {
            await _emailService.SendEmail(body);
            return Ok();
        }
    }
}
