using Microsoft.AspNetCore.Routing.Constraints;

namespace EmailCarbonFootprint.Models.Response
{
    public class EmailCarbonFootPrintInfo
    {
        public string? EmailId { get; set; }
        public double CarbonFootPrintByLongEmails { get; set; }
        public double CarbonFootPrintByStandardEmails { get; set; }
        public double CarbonFootPrintBySpamEmails { get; set; }
        public double TotalCarbonFootPrintByEmails { get; set; }

        public EmailCarbonFootPrintInfo(double carbonFootPrintByLongEmails, double carbonFootPrintByStandardEmails, double carbonFootPrintBySpamEmails)
        {
            this.CarbonFootPrintByLongEmails = carbonFootPrintByLongEmails;
            this.CarbonFootPrintByStandardEmails = carbonFootPrintByStandardEmails;
            this.CarbonFootPrintBySpamEmails = carbonFootPrintBySpamEmails;
            TotalCarbonFootPrintByEmails = CarbonFootPrintBySpamEmails + CarbonFootPrintByLongEmails + CarbonFootPrintByStandardEmails;
        }

    }
}
