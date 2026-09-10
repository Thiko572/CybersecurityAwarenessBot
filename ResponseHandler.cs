namespace CybersecurityAwarenessBot
{
    public class ResponseHandler
    {
        public string GetResponse(string userInput)
        {
            string clean = userInput.ToLower();

            if (clean.Contains("how are you"))
                return "I'm functioning perfectly, thank you for asking!";
            else if (clean.Contains("purpose"))
                return "My purpose is to educate you on cybersecurity topics so you can identify and mitigate online threats.";
            else if (clean.Contains("what can i ask") || clean.Contains("help"))
                return "You can ask me about:\n- Password safety\n- Phishing\n- Safe browsing\n- My purpose";
            else if (clean.Contains("password"))
                return "Password Safety Tip: Use a strong, unique password for every account. A good password is at least 12 characters long and contains symbols, numbers, and uppercase letters.";
            else if (clean.Contains("phishing"))
                return "Phishing Tip: Always check the sender's email address. Do not click on suspicious links or download unknown attachments.";
            else if (clean.Contains("safe browsing") || clean.Contains("browsing"))
                return "Safe Browsing Tip: Always look for 'https://' and a padlock icon before entering personal information.";
            else
                return "I didn't quite understand that. Could you rephrase?";
        }
    }
}