using EmailCarbonFootprint.Models.Request;
using EmailCarbonFootprint.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace EmailCarbonFootprint.Service.Interfaces
{
    public interface ICarbonFootPrintService
    {
        EmailCarbonFootPrintInfo GetCarbonFootPrintForEmail(EmailRequestDTO emailModel);
    }
}
