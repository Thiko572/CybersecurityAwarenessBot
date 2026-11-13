namespace CybersecurityChatbotGUI
{
    public class Chatbot
    {
        // ASCII art welcome banner
        public string GetAsciiArt()
        {
            return @"
============================================
   ____      _                                        _ _          
 / ___|   _| |__   ___ _ __ ___  ___  ___ _   _ _ __(_) |_ _   _  
| |  | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | '__| | __| | | | 
| |__| |_| | |_) |  __/ |  \__ \  __/ (__| |_| | |  | | |_| |_| | 
 \____\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|  |_|\__|\__, | 
      |___/                                                |___/

       CYBERSECURITY CHATBOT
       Your Online Safety Assistant
============================================
";
        }

        public string GetResponse(string message)
        {
            message = message.ToLower().Trim();

            if (message.Contains("hello") || message == "hi")
            {
                return "Hello! I am your Cybersecurity Awareness Assistant.";
            }

            if (message.Contains("password"))
            {
                return "Use a strong password with at least 16 characters. Never share it.";
            }

            if (message.Contains("phishing"))
            {
                return "Be careful of suspicious emails and links. Never click links you do not trust.";
            }

            if (message.Contains("scam"))
            {
                return "Be careful of offers that sound too good to be true. Never share your banking PIN.";
            }

            if (message.Contains("privacy"))
            {
                return "Protect your personal information and use secure internet connections.";
            }

            if (message.Contains("malware") || message.Contains("virus"))
            {
                return "Keep your antivirus software updated and avoid downloading unknown files.";
            }

            if (message.Contains("safe browsing"))
            {
                return "Visit trusted websites and check that the website address is correct.";
            }

            if (message.Contains("two-factor") || message.Contains("two factor"))
            {
                return "Enable two-factor authentication to add extra security to your accounts.";
            }

            if (message.Contains("worried") || message.Contains("scared"))
            {
                return "Do not worry. I can help you learn how to stay safe online.";
            }

            if (message == "help")
            {
                return "Ask me about passwords, phishing, scams, privacy, malware, safe browsing or two-factor authentication.";
            }

            return "I am not sure about that. Please ask me about a cybersecurity topic.";
        }
    }
}