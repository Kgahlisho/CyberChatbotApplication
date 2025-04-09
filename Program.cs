using System;
using System.Collections.Generic;
using System.Threading;
using System.Media;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace CyberChatbotApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //created an instance of CAAS in the main method 
            CassBot Caass = new CassBot();//created object called caass
            Caass.StartCaas();//Which will begin the CASS Application.
            //love
        }//end of main
    }//end of internal program

    class CassBot
    {
        private string name; //made the name to be private for it to be accessed only via the cyberberSecurityChatbot 

        private string[,] responses = new string[,]


            {

                { "nice to meet you" , "well im to have met you too, let me tell you something about me and you ask me what you would like to find out more about. \n I am CAAS and im mostly here to assist you with ready assured advice you might need , so do feel free to ask anything cybersecurity related and protection online related."},
                { "how are you" , "well im excited and keep in mind that im here to assist you with ready assured advice you might need , so do feel free to ask anything cybersecurity related and protection online related."},
                { "tell me more" , "this is the practice of protecting computer systems, networks, and data from unauthorized access, use, disclosure, disruption, modification, or destruction, encompassing various technologies, processes, and policies. "},
                { "safety" , "If your privacy settings are not secure, anyone can see your information ,  Don't share personal information like your address, phone number or bank details."},
                { "vpn" , " this VPNs acts like a secure tunnel, routing your internet traffic through a VPN server instead of directly through your internet service provider (ISP). "},
                { "online protection" , "is the level of privacy protection an individual has while connected to the Internet. It covers the amount of online security available for personal and financial data, communications, and preferences."},
                { "cyber security" , "he practices and measures implemented to protect user accounts and sensitive information from unauthorized access by using strong, unique, and regularly updated passwords, and employing additional security measures like password managers and multi-factor authentication"},
                { "password" , "ooh boy i sure like a challenge , okay when you make a password you make sure that you use a strong password , with a mix of letter, digits , characters and sysmbols. And make sure that it surpasses at least 8 characters to make hackers and whoever it is trying to gain access to your information will sure enough not succeed, do take not that it is not advisable to reuse the same password across different accounts."},
                { "phishing", "Phishing is a cyber attack where someone pretends to be trustworthy to steal your info." },
                { "exit", "Stay safe out there! Goodbye!" },
                { "how are you" , "well im excited and keep in mind that im here to assist you with ready assured advice you might need , so do feel free to ask anything cybersecurity related and protection online related."},
                { "what are you" , "well im a chatbot assistant, here to assist you with ready assured advice you might need , so do feel free to ask anything related to cybersecurity and protection online." },
                { "What do you do" ,"Well my purpose is to be able to educate you and make you aware of the threats of the Cyberworld and help you when you might have occured or encountered such threats."},
                { "what can you do", "You can ask me about password safety, phishing emails, or how to recognize suspicious links." },
                { "what can i ask you", " You can ask me about password safety, phishing emails, or how to recognize suspicious links." },
                { "What is your purpose ?" ,"Well my purpose is to be able to educate you and make you aware of the threats of the Cyberworld and help you when you might have occured or encountered such threats."},
                { "what can a bot like you do ?" , "i can provide tips on anything cybersecurity related , be able to assist you in recognising phishing attempts to your mobile or personal compters emails or more importantly , recognising thosesuspicious links you never think they are out to harm you."  },


            };//end of array



        public void StartCaas()
        {// image

            logo();


            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
                                                     ---------------------------------------------------------------------------
                                                     |                                                                         |
                                                     |                     ██████╗ █████╗  █████╗ ███████╗                     |
                                                     |                    ██╔════╝██╔══██╗██╔══██╗╚══███╔╝                     |
                                                     |                    ██║     ███████║███████║  ███╔╝                      |
                                                     |                    ██║     ██╔══██║██╔══██║ ███╔╝                       |
                                                     |                    ╚██████╗██║  ██║██║  ██║███████╗                     |
                                                     |                     ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝                     |
                                                     |                                                                         |
                                                     ----------------[    CYBERSECURITY AWARENESS ASSISTANT    ]----------------
                ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("                                                                WELCOME TO YOUR CYBERSECURITY AWARNESS ASSISTANT !!                              ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.White;


            PlayGreeting();//the voice greeting will start playing after the application has started 



            Console.Write(" Please enter your name : ");
            name = Console.ReadLine()?.Trim();//This reads the users input and it removes any white space that it encounters 


            while (string.IsNullOrEmpty(name))
            {

                Console.Write(" Name cannot be empty , please enter your name to continue. ");
                name = Console.ReadLine()?.Trim();//it will keep asking the user until the user s enter their name.
                //make sure that the user eneters a name using string characters instead of chars and int or leaving it empty

            }//end of validtion while loop

            Console.WriteLine($"\n Hello , {name}! My name is CAAS ,im here to help you with anything related to cybersecurity awarness and potentially make your expirience online a safe haven too.  ");
            Console.WriteLine(" You can ask my anything related to online safety & security , passwords , phishing and what it is ,and whether or not its safe to browser onine or  not.");

            Console.WriteLine($" ask away, {name} ! and do try to go easy on me im still in development too :).");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n You can ask a question or you can enter exit to leave the application.");
            Console.ForegroundColor = ConsoleColor.White;

            Caas();

        }//end of method



        private void Caas()
        {
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Blue;//the users prompt chate will appear and it will use the users entered name 
                Console.Write($" \n {name}:");
                string input = Console.ReadLine()?.Trim().ToLower();//reads the user inputs and removes any following occurances of whitespace
                //Changed this function for it doesnt quite satisfy the functionality of sensitivity because it is very quite case sensitive

                Console.ForegroundColor = ConsoleColor.White;
                if (string.IsNullOrEmpty(input))
                {

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(" CAAS : I didn't quite catch that, could you maybe rephrase the question you've asked and try asking me about cybersecurity");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;

                }//end of if

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(" CAAS: Stay safe out there ! Goodbye ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                }//end of if


                string responses = FindKeywords(input); //finds the keywaords in the users input

                Console.Write(" CAAS : ");
                Console.ForegroundColor = ConsoleColor.Gray;
                delayEffect(responses);
                Console.ForegroundColor = ConsoleColor.White;


            }//end of while loop
        }//end of CAAS method.



        private string FindKeywords(string input)//This method will check for keywords in the users input so that it doesnt have to mtch the exact word in oredr to recivea response
        {

            string cleanInput = input.ToLower().Trim();
            cleanInput = new string (cleanInput.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray());


            for (int i = 0; i < responses.GetLength(0); i++)
            {

                string keyword = responses[i,0].ToLower();

                if ( cleanInput.Contains(keyword))
                {
                    return responses[i, 1];
                }
            }
            return "didnt quite catch that , could you maybe rephrase that.";
        }//end of method.


        private void delayEffect(string text)// a text delay method that will enable the conversation bettwen user and CAAS to seem more interactivr
        {
            foreach (char c in text)
            {
                Console.Write(c);//made use of char in order to show character for character to show development of a sentence.
                Thread.Sleep(25);//the speed of 25
            }//end of for loop

            Console.WriteLine();
        }//end of method


        private void PlayGreeting()//instance of voice greeting method
        {

            string path = @"C:\Users\RC_Student_lab\source\repos\CyberChatbotApplication\voice_folder\greeting.wav";

            if (System.IO.File.Exists(path))
            {
                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
            else//the voice greeting is not located at said path directory
            {
                Console.WriteLine($"Error : voice not found at {path}");
            }
        }//end of greeting method

        private void logo()

        {
            string asciiPath = AppDomain.CurrentDomain.BaseDirectory;
            string newAsciiPath = asciiPath.Replace("bin\\Debug", "");
            string fullPath = Path.Combine(newAsciiPath, "C:\\Users\\RC_Student_lab\\source\\repos\\CyberChatbotApplication\\ascii_folder\\locked.jpeg");

            if (!File.Exists(fullPath))
            {
                Console.WriteLine($"Error: Image not found at {fullPath}");
                return;
            }

            Bitmap image = new Bitmap(fullPath);
            image = new Bitmap(image, new Size(25, 15)); // Resize for better fit

            ConsoleColor logoColor = ConsoleColor.Red;

            for (int height = 0; height < image.Height; height++)
            {
                for (int repeat = 0; repeat < 6; repeat++) // Print 3 logos side-by-side
                {
                    for (int width = 0; width < image.Width; width++)
                    {
                        Color pixelColor = image.GetPixel(width, height);
                        int brightness = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                        char asciiChar = brightness > 200 ? ',' : brightness > 150 ? '*' : brightness > 100 ? '0' : brightness > 50 ? '#' : '@';

                        Console.ForegroundColor = logoColor;
                        Console.Write(asciiChar);
                    }

                    Console.Write("  "); // Small space between logos
                }

                Console.WriteLine(); // Move to next line for all logos
            }

            Console.ForegroundColor = ConsoleColor.White; // Reset color
        }

    }//end of cassBot class

}//end of namespace
