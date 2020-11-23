using static RobinsOfgemYahooAutomationTest.Enums.GlobalEnums;

namespace RobinsOfgemYahooAutomationTest.Models
{
    public class EmailModel
    {
        public string Subject { get; set; }

        public string DateSent { get; set; }

        public string From { get; set; }

        public string BodyText { get; set; }

        public bool EmailRead { get; set; }

        public EmailFolder EmailFolder { get; set; }
    }
}
