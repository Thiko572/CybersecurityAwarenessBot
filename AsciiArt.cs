using System;

namespace CybersecurityAwarenessBot
{
    public class AsciiArt
    {
        public void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string logo = @"
  =======================================================
  ____      _                                        _ _          
 / ___|   _| |__   ___ _ __ ___  ___  ___ _   _ _ __(_) |_ _   _  
| |  | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | '__| | __| | | | 
| |__| |_| | |_) |  __/ |  \__ \  __/ (__| |_| | |  | | |_| |_| | 
 \____\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|  |_|\__|\__, | 
      |___/                                                |___/
  =======================================================
     CYBERSECURITY AWARENESS BOT - Stay Safe Online!
  =======================================================
";
            Console.WriteLine(logo);
            Console.ResetColor();
        }
    }
}