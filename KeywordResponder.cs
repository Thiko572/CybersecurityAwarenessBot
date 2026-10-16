using System;

namespace CybersecurityChatbotGUI
{
    public class KeywordResponder
    {
        Random random = new Random();

        public string FindTopic(string message)
        {
            message = message.ToLower();

            if (message.Contains("password")) return "password";
            if (message.Contains("phishing")) return "phishing";
            if (message.Contains("scam")) return "scam";
            if (message.Contains("privacy")) return "privacy";
            if (message.Contains("malware") ||
                message.Contains("virus")) return "malware";

            return "general";
        }

        public string Reply(string topic)
        {
            string[] answers;

            switch (topic)
            {
                case "password":
                    answers = new string[]
                    {
                        "Use a strong, unique password.",
                        "Never share your password.",
                        "Use multi-factor authentication."
                    };
                    break;

                case "phishing":
                    answers = new string[]
                    {
                        "Check the sender before clicking links.",
                        "Never enter your password on suspicious websites.",
                        "Report suspicious emails."
                    };
                    break;

                case "scam":
                    answers = new string[]
                    {
                        "Never share your banking PIN.",
                        "Verify messages before sending money.",
                        "Be careful of offers that seem too good to be true."
                    };
                    break;

                case "privacy":
                    answers = new string[]
                    {
                        "Keep personal information private.",
                        "Check your social media privacy settings.",
                        "Think before sharing information online."
                    };
                    break;

                case "malware":
                    answers = new string[]
                    {
                        "Keep your antivirus software updated.",
                        "Download files only from trusted sources.",
                        "Avoid opening unknown attachments."
                    };
                    break;

                default:
                    answers = new string[]
                    {
                        "Ask me about passwords, phishing, scams, privacy or malware.",
                        "I can help you learn how to stay safe online."
                    };
                    break;
            }

            return answers[random.Next(answers.Length)];
        }
    }
}