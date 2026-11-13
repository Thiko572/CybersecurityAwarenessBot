namespace CybersecurityChatbotGUI
{
    public class SentimentDetector
    {
        public string Detect(string message)
        {
            message = message.ToLower();

            if (message.Contains("worried") ||
                message.Contains("scared") ||
                message.Contains("afraid"))
                return "worried";

            if (message.Contains("angry") ||
                message.Contains("frustrated"))
                return "frustrated";

            if (message.Contains("happy") ||
                message.Contains("great"))
                return "positive";

            return "neutral";
        }
    }
}