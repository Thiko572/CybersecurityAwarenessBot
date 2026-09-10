using System;
using System.Threading;

namespace CybersecurityAwarenessBot
{
    public class Chatbot
    {
        private UserProfile _user = new UserProfile();
        private AsciiArt _art = new AsciiArt();
        private ResponseHandler _handler = new ResponseHandler();

        public void Start()
        {
            // 1. Play voice greeting FIRST
           
           // 2. Display ASCII art
            _art.DisplayLogo();

            // 3. Ask for name
            while (string.IsNullOrWhiteSpace(_user.Name))
            {
                Console.Write("Bot > Hello! What is your name?\nYou > ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input)) _user.Name = input.Trim();
                else Console.WriteLine("Bot > I did not catch your name. Please enter it again.");
            }

            // 4. Personalised greeting
            Console.WriteLine($"\nBot > Welcome {_user.Name}!");
            Console.WriteLine("I'm your Cybersecurity Awareness Assistant.");
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Ask me about: Password safety, Phishing, Safe browsing, or My purpose");
            Console.WriteLine("--------------------------------------------------\n");

            // 5. Conversation loop
            while (true)
            {
                Console.Write("You > ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput)) { Console.WriteLine("Bot > Please type a question."); continue; }

                if (userInput.ToLower() == "exit") { Console.WriteLine($"Bot > Goodbye, {_user.Name}. Stay safe online!"); break; }

                string response = _handler.GetResponse(userInput);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Bot > ");
                foreach (char c in response) { Console.Write(c); Thread.Sleep(15); }
                Console.WriteLine("\n");
                Console.ResetColor();
            }
        }
    }
}