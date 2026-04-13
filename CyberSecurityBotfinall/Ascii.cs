using System;

namespace CyberSecurityBotfinall
{
    public class ASCIIArt
    {
        private string asciiLogo = @"
   ____      _                 _                 
  / ___|   _| |__   ___   ___ | | ___   ___  ___
 | |  | | | | '_ \ / _ \ / _ \| |/ _ \ / _ \/ __|
 | |__| |_| | |_) | (_) | (_) | |  __/|  __/\__ \
  \____\__,_|_.__/ \___/ \___/|_|\___| \___||___/
        Cyber security Bot
";

        // Display ASCII logo
        public void DisplayLogo()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine(asciiLogo);
            Console.WriteLine("=========================================");
        }

        // Greet user
        public string GreetUser()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, let’s explore safe online practices together!\n");

            return userName; // optional (useful later if you want memory)
        }
    }
}
