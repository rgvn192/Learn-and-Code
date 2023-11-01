using EmailCarbonFootprint.Common;
using EmailCarbonFootprint.Models.Request;
using EmailCarbonFootprint.Models.Response;
using EmailCarbonFootprint.Service.Interfaces;

namespace EmailCarbonFootprint.Service
{
    public class CarbonFootPrintService : ICarbonFootPrintService
    {
        public EmailCarbonFootPrintInfo GetCarbonFootPrintForEmail(EmailModel emailModel)
        {

            var CarbonFootPrintByStandardEmails = emailModel.NumberOfStandardEmails * Constants.CarbonEmissionForStandardEmail;
            var CarbonFootPrintByLongEmails = emailModel.NumberOfLongEmails * Constants.CarbonEmissionForLongEmail;
            var CarbonFootPrintBySpamEmails = emailModel.NumberOfSpamEmails * Constants.CarbonEmissionForSpamEmail;

            return new EmailCarbonFootPrintInfo(CarbonFootPrintByLongEmails, CarbonFootPrintByStandardEmails, CarbonFootPrintBySpamEmails)
            {
                EmailId = emailModel.EmailId,
            };
        }
    }
}
