using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberChatbotApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //created an instance of CAAS in the main method 
            CassBot Caass = new CassBot();//created object called caass
            Caass.StartCaas();//Which will begin the CASS Application.

        }//end of method
    }//end of internal program

    class CassBot
    {
        private string name; //made the name to be private for it to be accessed only via the cyberberSecurityChatbot class
        
        public void StartCaas() { 

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("              WELCOME TO YOUR CYBERSECURITY AWARNESS ASSISTANT !!                         ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor= ConsoleColor.White;


            Console.Write("Please enter your name: ");
            name = Console.ReadLine()?.Trim();//This reads the users input and it removes any white space that it encounters 

            while (string.IsNullOrEmpty(name))
            {

                Console.Write(" Name cannot be empty , please enter your name to continue. ");
                name = Console.ReadLine()?.Trim();//it will keep asking the user until the user s enter their name.


            }//end of validtion while loop

            Console.WriteLine($"\nHello , {name}! My name is CAAS ,im here to help you with anything related to cybersecurity awarness and potentially make your expirience online a safe haven too.  ");
            Console.WriteLine("You can ask my anything related to online safety & security , passwords , phishing and what it is ,and whether or not its safe to browser onine or  not.");

            Console.WriteLine($"ask away, {name} ! and do try to go easy on me im still in development too :).");

            Caas();

        }//end of method

        private void Caas()
        {
            //we have to initialise a plathera of predifined responses the chatbot will utilise while interaction with the user 

            Dictionary<string, string> respond = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {


                { "How are you" , "well im excited , here to assist you with ready assured advice ,you might need so do feel free to ask anything."},

                { "What do you do" ," Well my purpose is to be able to educate you and make you aware of the threats of the Cyberworld and help you when you might have occured or encountered such threats."},

                { "what can you do", "You can ask me about password safety, phishing emails, or how to recognize suspicious links." },

                { "what can i ask you", "You can ask me about password safety, phishing emails, or how to recognize suspicious links." },

                { "purpose" ," Well my purpose is to be able to educate you and make you aware of the threats of the Cyberworld and help you when you might have occured or encountered such threats."},

                { "what can a bot like you do ?" , "i can provide tips on anything cybersecurity related , be able to assist you in recognising phishing attempts to your mobile or personal compters emails or more importantly , recognising thosesuspicious links you never think they are out to harm you."  },

                { "safety" , "ooh boy i sure like a challenge , okay like when you make a password you make sure that you use a strong password so satisfy saftety measures too , with a mix of letter, digits , characters and sysmbols. And make sure that it surpasses at least 8 characters to make sure hackers and whoever it is trying to gain access to your information will sure enough not succeed, do take not that it is not advisable to reuse the same password across different accounts.Also make sure not to play around those suspicios links too !"},

                { "Security" , "ooh boy i sure like a challenge , okay like when you make a password you make sure that you use a strong password so satisfy saftety measures too , with a mix of letter, digits , characters and sysmbols. And make sure that it surpasses at least 8 characters to make sure hackers and whoever it is trying to gain access to your information will sure enough not succeed, do take not that it is not advisable to reuse the same password across different accounts.Also make sure not to play around those suspicios links too !"},

                { "what is cyber safety" , "ooh boy i sure like a challenge , okay  when you make a password you make sure that you use a strong password so satisfy saftety measures too , with a mix of letter, digits , characters and sysmbols. And make sure that it surpasses at least 8 characters to make sure hackers and whoever it is trying to gain access to your information will sure enough not succeed, do take not that it is not advisable to reuse the same password across different accounts.Also make sure not to play around those suspicios links too !"},

                { "tell me more about password safety" , "ooh boy i sure like a challenge , okay when you make a password you make sure that you use a strong password , with a mix of letter, digits , characters and sysmbols. And make sure that it surpasses at least 8 characters to make hackers and whoever it is trying to gain access to your information will sure enough not succeed, do take not that it is not advisable to reuse the same password across different accounts."},

                { "password" , "ooh boy i sure like a challenge , okay when you make a password you make sure that you use a strong password , with a mix of letter, digits , characters and sysmbols. And make sure that it surpasses at least 8 characters to make hackers and whoever it is trying to gain access to your information will sure enough not succeed, do take not that it is not advisable to reuse the same password across different accounts."},

                { "what is phishing", "right, Phishing technically phishing is a cyber attack where attackers impersonate a trustworthy entity to steal yours or big companies sensitive information. So it is advisable also to be cautious of suspicious emails and links you do recieve in your emails!" },

                { "phishing", "right, Phishing technically phishing is a cyber attack where attackers impersonate a trustworthy entity to steal yours or big companies sensitive information. So it is advisable also to be cautious of suspicious emails and links you do recieve in your emails!" },

                { "how can i browse safely", "Always check website URLs, use HTTPS, and avoid clicking on unknown links. Keep your software and antivirus updated!" },

                { "browse", "Always check website URLs, use HTTPS, and avoid clicking on unknown links. Keep your software and antivirus updated!" }


            };//end of dictionary



            //then i created a while loop to keep the conversation going ,until the user  chooses to exit the application.
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Blue;//the users prompt chate will appear to be blue

                Console.Write("\nYou: ");
                string input = Console.ReadLine()?.Trim();//reads the user inputs and removes any following occurances of whitespace

                Console.ForegroundColor = ConsoleColor.White;//then it will revert back into white 

                if (string.IsNullOrEmpty(input))
                {

                    Console.ForegroundColor = ConsoleColor.Gray;//CAAS responses will appear to be gray

                    Console.WriteLine("CAAS : I didn't quite catch that, could you maybe rephrase the question you've asked ?");

                    Console.ForegroundColor = ConsoleColor.White;//then it will revert back into white 

                    continue;//continues to the next iteration

                }//end of if

                if (input.Equals("exit" , StringComparison.OrdinalIgnoreCase))
                {

                    Console.ForegroundColor = ConsoleColor.Gray;//CAAS responses will appear to be gray

                    Console.WriteLine("CAAS: Stay safe out there ! Goodbye ");

                    Console.ForegroundColor = ConsoleColor.White;//then it will revert back into white

                    break;//exit the loop and it end the application smoothly



                }//end of if


                if (respond.TryGetValue(input.ToLower(), out string response))//if statemnt that will get the appropriate response to the users questions from the reponse dictionary array list and turn all the users responses to smallcaps for better accessibiity
                {

                    Console.ForegroundColor = ConsoleColor.Green;// if the response can be found CAAS responses will appear to be green

                    Console.WriteLine($"CAAS : {response}");//This will display the bot CAAS's 

                    Console.ForegroundColor = ConsoleColor.White;//then it will revert back into white 

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;//CAAS responses will appear to be gray

                    Console.WriteLine("CAAS : i didnt understand what you said ,maybe try asking more about cybersecurity i sure will catch on quick!");

                    Console.ForegroundColor = ConsoleColor.White;//then it will revert back into white 

                }//end of if elsestatemnt


            
         
            }//end of while loop
        }//end of CAAS method
    }//end of class
}//end of namespace
