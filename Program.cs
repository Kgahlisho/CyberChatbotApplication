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

        }//end of main
    }//end of internal program

    class CassBot
    {
        private string name; //made the name to be private for it to be accessed only via the cyberberSecurityChatbot 

        private string[,] responses = new string[,]
            {
                { "hi", "Well hello, my name is CAAS and I'm here to assist you with cybersecurity advice. Feel free to ask anything related to online protection." },
                { "hello", "Well hi, my name is CAAS, and I'm here to help with cybersecurity-related questions!" },
                { "nice to meet you" , "well im to have met you too, let me tell you something about me and you ask me what you would like to find out more about. \n I am CAAS and im mostly here to assist you with ready assured advice you might need , so do feel free to ask anything cybersecurity related and protection online related."},
                { "how are you" , "well im excited and keep in mind that im here to assist you with ready assured advice you might need , so do feel free to ask anything cybersecurity related and protection online related."},
                { "what are you" , "well im a chatbot assistant, here to assist you with ready assured advice you might need , so do feel free to ask anything related to cybersecurity and protection online." },
                { "What do you do" ,"Well my purpose is to be able to educate you and make you aware of the threats of the Cyberworld and help you when you might have occured or encountered such threats."},
                { "what can you do", "You can ask me about password safety, phishing emails, or how to recognize suspicious links." },
                { "what can i ask you", " You can ask me about password safety, phishing emails, or how to recognize suspicious links." },
                { "What is your purpose ?" ,"Well my purpose is to be able to educate you and make you aware of the threats of the Cyberworld and help you when you might have occured or encountered such threats."},
                { "what can a bot like you do ?" , "i can provide tips on anything cybersecurity related , be able to assist you in recognising phishing attempts to your mobile or personal compters emails or more importantly , recognising thosesuspicious links you never think they are out to harm you."  },
                { "what is online safety" , "ooh boy i sure like a challenge , okay like when you make a password you make sure that you use a strong password so satisfy saftety measures too , with a mix of letter, digits , characters and sysmbols. And make sure that it surpasses at least 8 characters to make sure hackers and whoever it is trying to gain access to your information will sure enough not succeed, do take not that it is not advisable to reuse the same password across different accounts.Also make sure not to play around those suspicios links too !"},
                { "tell me more about security" , "ooh boy i sure like a challenge , okay to enhance your security when you create a password you have make sure that you use a strong password ," +
                    "\n so as to satisfy saftety measures too with a mix of letter, digits , characters and sysmbols. And make sure that it surpasses at least 8 characters to make sure hackers and whoever it is trying to gain access to your information will sure enough not succeed, do take not that it is not advisable to reuse the same password across different accounts.Also make sure not to play around those suspicios links too !"},
                { "what is cyber security ?" , "ooh boy i sure like a challenge , okay  when you make a password you make sure that you use a strong password so satisfy saftety measures too , with a mix of letter, digits , characters and sysmbols. And make sure that it surpasses at least 8 characters to make sure hackers and whoever it is trying to gain access to your information will sure enough not succeed, do take not that it is not advisable to reuse the same password across different accounts.Also make sure not to play around those suspicios links too !"},
                { "why do you protect your password ?" , "ooh boy i sure like a challenge , okay when you make a password you make sure that you use a strong password , with a mix of letter, digits , characters and sysmbols. And make sure that it surpasses at least 8 characters to make hackers and whoever it is trying to gain access to your information will sure enough not succeed, do take not that it is not advisable to reuse the same password across different accounts."},
                { "tell me more about passwords" , "ooh boy i sure like a challenge , okay when you make a password you make sure that you use a strong password , with a mix of letter, digits , characters and sysmbols. And make sure that it surpasses at least 8 characters to make hackers and whoever it is trying to gain access to your information will sure enough not succeed, do take not that it is not advisable to reuse the same password across different accounts."},
                { "how can i protect myself online ?" , "You have to make sure that your password is very strong and you dont share it with anyone, make sure that you dont click on random links that you dont know because that will cost you dearly too, and dont use the same password on multiple pages online."},
                { "tell me more ","can you be specific , because i can tell you more about cybersecurity topics."},
                { "what is phishing ?", "right, Phishing technically phishing is a cyber attack where attackers impersonate a trustworthy entity to steal yours or big companies sensitive information. So it is advisable also to be cautious of suspicious emails and links you do recieve in your emails!" },
                { "phishing", "right, Phishing technically phishing is a cyber attack where attackers impersonate a trustworthy entity to steal yours or big companies sensitive information. So it is advisable also to be cautious of suspicious emails and links you do recieve in your emails!" },
                { "how can i browse safely online ?", "Always check website URLs, use HTTPS, and avoid clicking on unknown links. Keep your software and antivirus updated!" },
                { "browse", "Always check website URLs, use HTTPS, and avoid clicking on unknown links. Keep your software and antivirus updated!" },
                { "how are you", "I'm always ready to assist! Feel free to ask me anything about online safety." },
                { "exit", "Stay safe out there! Goodbye!" }

            };//end of array



        public void StartCaas() {// image

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
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
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

            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("\n You can ask a question or you can enter exit to leave the application.");
            Console.ForegroundColor=ConsoleColor.White;

            Caas();

        }//end of method



        private void Caas()
        {   
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Blue;//the users prompt chate will appear and it will use the users entered name 
                Console.Write($"\n{name}:");
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

                
                string response = FindKeywords(input); //finds the keywaords in the users input

                Console.Write(" CAAS : ");
                Console.ForegroundColor = ConsoleColor.Gray;
                delayEffect(response);
                Console.ForegroundColor = ConsoleColor.White;   

         
            }//end of while loop
        }//end of CAAS method.



        private string FindKeywords(string input)//This method will check for keywords in the users input so that it doesnt have to mtch the exact word in oredr to recivea response
        {

            for (int i = 0; i < responses.GetLength(0); i++)
            {
                if (input.IndexOf(responses[i, 0], StringComparison.OrdinalIgnoreCase) >= 0 )
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
            {
                string asciiPath = AppDomain.CurrentDomain.BaseDirectory;

                string newAsciiPath = asciiPath.Replace("bin\\Debug", "");

                string fullPath = Path.Combine(newAsciiPath, "C:\\Users\\RC_Student_lab\\source\\repos\\CyberChatbotApplication\\ascii_folder\\locked.jpeg");

                Bitmap image = new Bitmap(fullPath);
                image = new Bitmap(image, new Size(35, 25));

                for (int height = 0; height < image.Height; height++)
                {
                    for (int width = 0; width < image.Width; width++)
                    {

                        Color pixelColor = image.GetPixel(width, height);
                        int color = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        char asciiDesgin = color > 200 ? ',' : color > 150 ? '*' : color > 100 ? '0' : color > 50 ? '#' : '@';
                        Console.Write(asciiDesgin);



                    }
                    Console.WriteLine();
                }//endof for loop
            }
        }//end of logo


    }//end of cassBot class

}//end of namespace
