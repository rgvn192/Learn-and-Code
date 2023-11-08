using EmailCarbonFootprint.Models.Request;
using EmailCarbonFootprint.Models.Response;
using EmailCarbonFootprint.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EmailCarbonFootprint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarbonFootPrintController : ControllerBase
    {
        
        private readonly ILogger<CarbonFootPrintController> _logger;
        private readonly ICarbonFootPrintService _carbonFootPrintService;

        public CarbonFootPrintController(ILogger<CarbonFootPrintController> logger, ICarbonFootPrintService carbonFootPrintService)
        {
            _logger = logger;
            _carbonFootPrintService = carbonFootPrintService;
        }

        [HttpPost]
        public ActionResult<EmailCarbonFootPrintInfo> GetCarbonFootPrintForEmail(EmailRequestDTO emailModel)
        {
            try
            {
                return Ok(_carbonFootPrintService.GetCarbonFootPrintForEmail(emailModel));
            }
            catch(Exception ex) 
            {
                _logger.LogError(ex.Message);
                return Problem(statusCode: (int)HttpStatusCode.BadRequest, title: ex.Message, type: ((int)HttpStatusCode.BadRequest).ToString());
            }
        }
    }
}