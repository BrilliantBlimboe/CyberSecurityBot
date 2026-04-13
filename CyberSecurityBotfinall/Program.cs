using CyberSecurityBotfinall;
using CyberSecurityBotfinall.Properties;
using System;
using System.Media;
using System.Resources;
using System.Runtime.Remoting.Channels;
using System.Threading;

namespace CyberSecurityBotfinall
{
    internal class Program
    {
        // Typing effect
        static void TypeText(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(10); // small delay
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // half a second pause
            Thread.Sleep(500);

            // Play welcome audio
            SoundPlayer player = new SoundPlayer(Resources.greeting_wav);
            player.Play();


            ASCIIArt art = new ASCIIArt();

            // Border + Heading
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.ResetColor();

            // ASCII Logo
            art.DisplayLogo();

            // Greeting
            art.GreetUser();

            Console.WriteLine("\nType 'quit' to exit the chat.\n");

            string userInput = "";

            while (userInput != "quit")
            {
                // User input (colour)
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("You: ");
                Console.ResetColor();

                userInput = Console.ReadLine().ToLower();

                Console.ForegroundColor = ConsoleColor.Yellow;

                if (userInput == "hello" || userInput == "hi")
                {
                    TypeText("ChatBox: Hello! How can I assist you?");
                }
                else if (userInput.Contains("how are you"))
                {
                    TypeText("ChatBox: I'm good! How can I assist you today.");
                }
                else if (userInput.Contains("what is your purpose") || userInput.Contains("what can i ask you about"))
                {
                    TypeText("ChatBox: My purpose is to raise awareness about cybersecurity.");
                }
                else if (userInput.Contains("phishing"))
                {
                    TypeText("ChatBox:Phishing is a type of cyber attack where attackers try to trick people into revealing sensitive information, like passwords, credit card numbers, or personal details. ");
                }
                else if (userInput.Contains("malware"))
                {
                    TypeText("ChatBox:Malware is malicious software designed to disrupt, damage, or gain unauthorized access to computer systems, and it can significantly impact domains by compromising security and data integrity.");
                }
                else if (userInput.Contains("ransomware"))
                {
                    TypeText("ChatBox: Ransomware is a type of malware that encrypts a victim's files or locks them out of their system, demanding a ransom payment to restore access.");
                }
                else if (userInput.Contains("engineering"))
                {
                    TypeText("ChatBox: Social engineering is a type of cyberattack that exploits human behavior rather than technical vulnerabilities to gain access to sensitive information, systems, or physical locations.");
                }
                else if (userInput.Contains("ddos"))
                {
                    TypeText("ChatBox: A Distributed Denial of Service (DDoS) attack is a malicious attempt to disrupt the normal traffic of a targeted server, service, or network by overwhelming it with a flood of Internet traffic. ");
                }
                else if (userInput.Contains("password"))
                {
                    TypeText("ChatBox: Strong, unique passwords are essential for online security, and using a password manager or generator can simplify creating and storing them safely");
                }
                else if (userInput.Contains("authentication"))
                {
                    TypeText("ChatBox: Two-factor authentication strengthens account security by requiring two different types of identity verification before granting access to an account or system.");
                }
                else if (userInput.Contains("firewall"))
                {
                    TypeText("ChatBox: Two-factor authentication strengthens account security by requiring two different types of identity verification before granting access to an account or system.");
                }
                else if (userInput.Contains("vpn"))
                {
                    TypeText("ChatBox: A VPN encrypts your internet connection, providing privacy and security when using public networks.");
                }
                else if (userInput.Contains("update") || userInput.Contains("patch"))
                {
                    TypeText("ChatBox: Keep your software updated to protect against vulnerabilities.");
                }
                else if (userInput.Contains("backup"))
                {
                    TypeText("ChatBox: Regularly back up your data to prevent loss.");
                }
                else if (userInput.Contains("encryption"))
                {
                    TypeText("ChatBox: Encryption protects your data from unauthorized access.");
                }
                else if (userInput.Contains("social media"))
                {
                    TypeText("ChatBox: Be cautious about what you share on social media.");
                }
                else if (userInput.Contains("public wifi"))
                {
                    TypeText("ChatBox: Avoid using public Wi-Fi for sensitive activities.");
                }
                else if (userInput.Contains("antivirus"))
                {
                    TypeText("ChatBox: Antivirus is a type of software designed to detect, prevent, and remove malicious software (malware) from your computer, phone, or network. It acts like a security guard for your device. ");
                }
                else if (userInput.Contains("cybersecurity tips") || userInput.Contains("cybersecurity advice"))
                {
                    TypeText("ChatBox: Here are some cybersecurity tips: 1. Use strong, unique passwords. 2. Enable two-factor authentication. 3. Keep software updated. 4. Be cautious of phishing attempts. 5. Regularly back up your data.");
                }
                else if (string.IsNullOrWhiteSpace(userInput))
                {
                    TypeText("ChatBox: Please enter a valid question.");
                }
                else if (userInput == "quit")
                {
                    TypeText("ChatBox: Goodbye! Stay safe online.");
                }
                else
                {
                    TypeText("ChatBox: I don't have information on that topic.");
                }

                Console.ResetColor();

                // Divider
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
