﻿using Microsoft.AspNetCore.Routing.Constraints;

namespace EmailCarbonFootprint.Models.Response
{
    public class EmailCarbonFootPrintInfo
    {
        public string? EmailId { get; set; }
        public double CarbonFootPrintByLongEmails { get; set; }
        public double CarbonFootPrintByStandardEmails { get; set; }
        public double CarbonFootPrintBySpamEmails { get; set; }
        public double TotalCarbonFootPrintByEmails { get; set; }

        public EmailCarbonFootPrintInfo(double CarbonFootPrintByLongEmails, double CarbonFootPrintByStandardEmails, double CarbonFootPrintBySpamEmails)
        {
            this.CarbonFootPrintByLongEmails = CarbonFootPrintByLongEmails;
            this.CarbonFootPrintByStandardEmails = CarbonFootPrintByStandardEmails;
            this.CarbonFootPrintBySpamEmails = CarbonFootPrintBySpamEmails;
            TotalCarbonFootPrintByEmails = CarbonFootPrintBySpamEmails + CarbonFootPrintByLongEmails + CarbonFootPrintByStandardEmails;
        }

    }
}
