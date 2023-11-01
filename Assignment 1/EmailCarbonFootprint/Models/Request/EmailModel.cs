namespace EmailCarbonFootprint.Models.Request
{
    public class EmailModel
    {
        public string EmailId { get; set; }
        public int NumberOfStandardEmails { get; set; }
        public int NumberOfLongEmails { get; set; }
        public int NumberOfSpamEmails { get; set; }

    }
}
