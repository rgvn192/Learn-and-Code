using EmailCarbonFootprint.Common;
using EmailCarbonFootprint.Models.Request;
using EmailCarbonFootprint.Models.Response;
using EmailCarbonFootprint.Service.Interfaces;

namespace EmailCarbonFootprint.Service
{
    public class CarbonFootPrintService : ICarbonFootPrintService
    {
        public EmailCarbonFootPrintInfo GetCarbonFootPrintForEmail(EmailRequestDTO emailModel)
        {

            var carbonFootPrintByStandardEmails = emailModel.NumberOfStandardEmails * Constants.CarbonEmissionForStandardEmail;
            var carbonFootPrintByLongEmails = emailModel.NumberOfLongEmails * Constants.CarbonEmissionForLongEmail;
            var carbonFootPrintBySpamEmails = emailModel.NumberOfSpamEmails * Constants.CarbonEmissionForSpamEmail;

            return new EmailCarbonFootPrintInfo(carbonFootPrintByLongEmails, carbonFootPrintByStandardEmails, carbonFootPrintBySpamEmails)
            {
                EmailId = emailModel.EmailId,
            };
        }
    }
}
