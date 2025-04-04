using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Voice_greet_Draft
{
    public class Program
    {
        static void Main(string[] args)
        {

            //creating instances for classes
            new voice_() { };
            new logo() { };
            new user_interface() { };
            //new split_function() { };
            new ArrayList();
        }
    }
}

using System;
using System.IO;
//imported the system.media
using System.Media;
namespace Voice_greet_Draft
{
    public class voice_
    {

        //constructor
        public voice_()
        {
            //fetch the project bobby
            string voice_location = AppDomain.CurrentDomain.BaseDirectory;

            //replacing the bins and the debugs for bobby to fetch the voice greeting
            string voice_path = voice_location.Replace("bin\\Debug\\", "");
            //combining the wav name and the voice patch that bobby fetched
            string full_path = Path.Combine(voice_path, "voice_greeting.wav");
            //bobby is now passing the voice to the owner which is the method
            voice_wav(full_path);


        }// end of constructor

        //method to play the voice greeting
        private void voice_wav(string full_path)
        {
            //try and catch for exception handling
            try
            {
                //voice greeting
                using (SoundPlayer voice = new SoundPlayer(full_path))
                {
                    //playing the voice
                    voice.PlaySync();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("something went wrong. LOL!");
            }//end of out try aand catch


        }//end of class
    }

}//end of namespace

using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
namespace Voice_greet_Draft
{
    public class logo

    {
        public logo()
        {

             //location of the logo
            string image_location = AppDomain.CurrentDomain.BaseDirectory;
            string location = image_location.Replace("bin\\Debug\\", "");

            string imagePath = Path.Combine(location, "Avangers.png");

            Bitmap image = new Bitmap(imagePath);
            image = new Bitmap(image ,new Size(90, 50));

            for (int y = 0; y < image.Height; y++)
            {
                //working on the width
                for (int x = 0; x < image.Width; x++)
                {
                    //asci design
                    Color pixelColor = image.GetPixel(x, y);
                    int color = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char asciiChar = color > 200 ? '.' : color > 150 ? '*' : color > 100 ? '0' : color > 50 ? '#': '@';
                    Console.Write(asciiChar);


                }//end of the for loop for inner
                Console.WriteLine();
            }//end of the for loop for outer
        }
    }
}
//

using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Voice_greet_Draft
{
    public class split_function
    {
        //variable declarations

        //global variable declaration and array

        private ArrayList reply = new ArrayList();
        private ArrayList ignores = new ArrayList();


        public void   searching(string question)
        {

            //calling both methods store_replies and store_ignore
            store_replies();
            store_ignore();

          

             
           

                //use split function
                string[] store_word = question.ToLower().Split(' ');

                //temp arratlist
                ArrayList filter = new ArrayList();

                //for loop to display and add to temp array
                for (int count = 0; count < store_word.Length; count++)
                {

                    //check to final store
                    if (!ignores.Contains(store_word[count]))
                    {
                        //store final
                        filter.Add(store_word[count]);

                    }//end of if statement

                }//end of for loop

                //boolean for correct found answer
                Boolean found = false;
                string message = "";

                //then display the answer
                for (int counting = 0; counting < filter.Count; counting++)
                {

                    //nested for loop
                    for (int counts = 0; counts < reply.Count; counts++)
                    {

                        if (reply[counts].ToString().ToLower().Contains(filter[counting].ToString()))
                        {

                            found = true;
                            message += reply[counts] + "\n";

                        }//end of if

                    }//end of reply for loop

                }//end of get answer for loop

                //if for display, if user asks something out of cyber security

                if (found)
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("Write something related to cyber security");
                }//end of display

          

        }//end of constructor

        //Create method for storing all replies
        private void store_replies()
        {
            //add values to arraylist

            reply.Add(" I am feeling well thanks, What would you like assistance with today?");

            reply.Add("Ask me about cyber security");

            reply.Add("My purpose is to help you  stay safe online, and educate you all about cyber security! ");

            reply.Add("Phishing is a cybercrime where attackers deceive individuals into revealing sensitive information");
            reply.Add("Phishing is a form of social engineering and a scam where attackers deceive people into revealing sensitive information");
            reply.Add("Phishing is a types of social engineering attack where attackers trick individuals into revealing sensitive information, such as usernames, or credit card details, by pretending to be a trustworthy entity (e.g., a bank or a service provider).");

            reply.Add("Ransomware is malicious software (malware) that locks or encrypts a victim's data, making it inaccessible. The attacker demands a ransom (usually in cryptocurrency) to unlock or decrypt the data.");

            reply.Add("A strong password should be long (at least 12 characters) and include a mix of upper and lowercase letters, numbers, and special characters.");

            reply.Add("In a DoS attack, a single system is used to flood a network or website with excessive traffic, causing it to become overwhelmed and crash. In a DDoS attack, the traffic is distributed across many systems (often botnets), making it more difficult to stop.");

            reply.Add("A Man-in-the-Middle (MitM) attack occurs when an attacker intercepts and possibly alters the communication between two parties (e.g., between a user and a website), stealing sensitive information or injecting malicious content.");

            reply.Add("SQL injection occurs when an attacker inserts malicious SQL queries into input fields on websites or applications that do not properly validate user input. These queries can manipulate the database, steal, or alter data.");

            reply.Add("Malware is software intentionally designed to cause damage to a system. It includes viruses, worms, Trojans, and spyware, often spreading through malicious email attachments, infected websites, or software vulnerabilities.");

            reply.Add("Safe browsing practices help protect your privacy, prevent malware infections, and keep your personal data secure while navigating the web.");

            reply.Add("Cross-Site Scripting (XSS) attacks occur when an attacker injects malicious scripts into web pages viewed by other users. These scripts can steal session cookies, redirect users to malicious websites, or alter page content.");

            reply.Add("Credential stuffing is when attackers use automated tools to try large numbers of username and password combinations, typically obtained from previous data breaches, to gain unauthorized access to accounts.");

            reply.Add("A zero-day exploit takes advantage of a software vulnerability that has not been discovered or patched by the vendor. Attackers exploit these vulnerabilities before the software maker releases a fix.");

            reply.Add("An insider threat involves a current or former employee, contractor, or business partner who intentionally or unintentionally causes harm to an organization’s security, often by stealing or exposing sensitive data.");

            reply.Add("A drive-by download attack occurs when a user unknowingly downloads malware by visiting a compromised website, with the malware being downloaded and executed automatically without the user's consent.");

            reply.Add("Social engineering involves manipulating individuals into divulging confidential information by exploiting trust, fear, or other psychological triggers, often through phone calls, emails, or in-person interaction.");

            reply.Add("In a supply chain attack, cybercriminals compromise software or hardware providers to gain access to their clients, targeting smaller companies in the supply chain with weaker security defenses as a backdoor to larger targets.");
            

        }//end of store_replies

        //method to store ignores
        private void store_ignore()
        {
       
            // Add values to the ignore array list
            ignores.Add("tell");
            ignores.Add("attack");
            ignores.Add("me");
            ignores.Add("about");
            ignores.Add("how");
            ignores.Add("do");
            ignores.Add("use");
            ignores.Add("is");
            ignores.Add("more");
            ignores.Add("and");
            ignores.Add(",");
            ignores.Add("are");
            ignores.Add("you");
            ignores.Add("?");
            ignores.Add("what");
            ignores.Add("i");
            ignores.Add("can");
            ignores.Add("the");
            ignores.Add("in");
            ignores.Add("to");
            ignores.Add("that");
            ignores.Add("this");
            ignores.Add("it");
            ignores.Add("for");
            ignores.Add("on");
            ignores.Add("with");
            ignores.Add("at");
            ignores.Add("a");
            ignores.Add("an");
            ignores.Add("of");
            ignores.Add("as");
            ignores.Add("by");
            ignores.Add("up");
            ignores.Add("down");
            ignores.Add("but");
            ignores.Add("no");
            ignores.Add("yes");
            ignores.Add("not");
            ignores.Add("or");
            ignores.Add("be");
            ignores.Add("will");
            ignores.Add("just");
            ignores.Add("have");
            ignores.Add("if");
            ignores.Add("their");
            ignores.Add("they");
            ignores.Add("isn't");
            ignores.Add("aren't");
            ignores.Add("was");
            ignores.Add("were");
            ignores.Add("am");
            ignores.Add("been");
            ignores.Add("being");
            ignores.Add("does");
            ignores.Add("doesn't");
            ignores.Add("did");
            ignores.Add("didn't");
            ignores.Add("has");
            ignores.Add("hasn't");
            ignores.Add("had");
            ignores.Add("hadn't");
            ignores.Add("having");
            ignores.Add("may");
            ignores.Add("might");
            ignores.Add("must");
            ignores.Add("should");
            ignores.Add("would");
            ignores.Add("could");
            ignores.Add("not");
            ignores.Add("each");
            ignores.Add("every");
            ignores.Add("some");
            ignores.Add("any");
            ignores.Add("all");
            ignores.Add("few");
            ignores.Add("more");
            ignores.Add("less");
            ignores.Add("most");
            ignores.Add("least");
            ignores.Add("one");
            ignores.Add("two");
            ignores.Add("three");
            ignores.Add("four");
            ignores.Add("five");
            ignores.Add("six");
            ignores.Add("seven");
            ignores.Add("eight");
            ignores.Add("nine");
            ignores.Add("ten");
            ignores.Add("so");
            ignores.Add("then");
            ignores.Add("because");
            ignores.Add("since");
            ignores.Add("until");
            ignores.Add("while");
            ignores.Add("during");
            ignores.Add("before");
            ignores.Add("after");
            ignores.Add("between");
            ignores.Add("along");
            ignores.Add("among");
            ignores.Add("through");
            ignores.Add("across");
            ignores.Add("over");
            ignores.Add("under");
            ignores.Add("down");
            ignores.Add("up");
            ignores.Add("out");
            ignores.Add("into");
            ignores.Add("onto");
            ignores.Add("upon");
            ignores.Add("within");
            ignores.Add("without");
            ignores.Add("alongside");
            ignores.Add("except");
            ignores.Add("although");
            ignores.Add("even");
            ignores.Add("either");
            ignores.Add("neither");
            ignores.Add("both");
            ignores.Add("such");
            ignores.Add("whose");
            ignores.Add("whether");
            ignores.Add("rather");
            ignores.Add("then");
            ignores.Add("thus");
            ignores.Add("however");
            ignores.Add("yet");
            ignores.Add("there");
            ignores.Add("here");
            ignores.Add("where");
            ignores.Add("when");
            ignores.Add("why");
            ignores.Add("how");
        }






    }//end of store_ignore



}



using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Voice_greet_Draft
{
    public class user_interface
    {
        private ArrayList answers = new ArrayList();

        private ArrayList mize = new ArrayList();

        //declaring our variables
        private string userName = string.Empty;
        private string askUser = string.Empty;

        //fix exception handling
        //ask the bot how is it going
        //when the the user enters nothung it needs to let the user knoow to enter something
        // 

        //constructor
       public user_interface()
        {

        //welcomimg the user
        //chnge the color
        Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("****************************************");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("[    Welcome to the cyber security awareness bot   ]");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("****************************************");

            //the AI has to ask the userr for their name
            Console.ForegroundColor= ConsoleColor.White;
            Console.Write("ChatBot >>");
            //color for questions
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************************");
            Console.WriteLine("Hello friend, please enter your name >>");
             Console.WriteLine("**************************************************");
            //user enters their name
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Friend >> ");
            Console.ForegroundColor = ConsoleColor.White;
            //name of the user
            userName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Friend >> ");
            //gray color for the question

            Console.WriteLine("**************************************************");
            Console.WriteLine("Hey " + userName + ", how can i assit you today?");

            Console.WriteLine("**************************************************");
            do
            {
                
                   Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(userName + ">>");
                //color reset
                Console.ForegroundColor = ConsoleColor.White;
                //asking the question
                askUser = Console.ReadLine();

               answer_(askUser);
            } while (askUser != "exit");// end of do while loop


        }//end of the constructor
        //answering method


        private void answer_ (string asked)
        {
            //checking conditions
            if (string.IsNullOrWhiteSpace(asked))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ChatBot >> Please ask me a question related to cyber security.");
               
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            asked = asked.ToLower().Trim();

            // chatbot responses
            if (asked == "how are you")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ChatBot >> ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I am well, thanks! What would you like assistance with today?");
 
               Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else if (asked == "what is your purpose?")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ChatBot >> ");
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.WriteLine("My purpose is to help you stay safe online and educate you about cyber security.");
               
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else if (asked == "what can i ask you about?")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ChatBot >> ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can ask me about various cyber security topics, including phishing, ransomware, strong passwords, DoS attacks, and more.");
              
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            // If input is valid, proceed with normal processing
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ChatBot >> ");
            Console.ForegroundColor = ConsoleColor.Red;

            // Call split_function to process question
            split_function search = new split_function();
            search.searching(asked);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ChatBot >> ");
            Console.ForegroundColor = ConsoleColor.Red;
   
            Console.WriteLine("We hope the answer was helpful.");
            Console.ForegroundColor = ConsoleColor.White;

        }//the end of our method of asking

        private void store_answers()
        {

             answers.Add("I am well thanks, what would you like assistance with today");
            answers.Add("My purpose is to help you stay safe online, and educate you all about cyber security");
            //phishing comments
            answers.Add("- Phishing is a cybercrime where attackers deceive individuals into revealing sensitive information");
            answers.Add("- Phishing is a form of social engineering and a scam where attackers deceive people into revealing sensitive information");
            answers.Add("- Phishing is a type of social engineering attack where attackers trick individuals into revealing sensitive information, such as usernames, passwords, or credit card details, by pretending to be a trustworthy entity (e.g., a bank or a service provider).");
            //Ransomware comments
            answers.Add("Ransomware is malicious software (malware) that locks or encrypts a victim's data, making it inaccessible. The attacker demands a ransom (usually in cryptocurrency) to unlock or decrypt the data.");
            answers.Add("A form of malicious software that encrypts or blocks access to a victim’s files, data, or systems.");
            answers.Add("Cybercriminals use it to hold data hostage and demand a ransom payment for access restoration");
            //DoS comments
            answers.Add("In a DoS attack, a single system is used to flood a network or website with excessive traffic, causing it to become overwhelmed and crash. In a DDoS attack, the traffic is distributed across many systems (often botnets), making it more difficult to stop.");
            answers.Add("DoS is an attack where hackers make the system unavailable to users, preventing them from accessing tje network or website");
            answers.Add("DoS attacks are attempts to interrupt a website or network’s operations by overwhelming it with traffic.");
            //Man in the middle comments
            answers.Add("A Man-in-the-Middle (MitM) attack occurs when an attacker intercepts and possibly alters the communication between two parties (e.g., between a user and a website), stealing sensitive information or injecting malicious content.");
            answers.Add("Man in the middle is the type of an attack where hackers interrupt communication between two partues in order to steal the login credentials");
            answers.Add("MitM attacks are attempts to \"intercept\" electronic communications – to snoop on transmissions in an attack on confidentiality or to alter them in an attack on integrity.");

            answers.Add("SQL injection occurs when an attacker inserts malicious SQL queries into input fields on websites or applications that do not properly validate user input. These queries can manipulate the database, steal, or alter data.");
           
            answers.Add("Malware is software intentionally designed to cause damage to a system. It includes viruses, worms, Trojans, and spyware, often spreading through malicious email attachments, infected websites, or software vulnerabilities.");
           
            answers.Add("Cross-Site Scripting (XSS) attacks occur when an attacker injects malicious scripts into web pages viewed by other users. These scripts can steal session cookies, redirect users to malicious websites, or alter page content.");
           
            answers.Add("Credential stuffing is when attackers use automated tools to try large numbers of username and password combinations, typically obtained from previous data breaches, to gain unauthorized access to accounts.");
           
            answers.Add("A zero-day exploit takes advantage of a software vulnerability that has not been discovered or patched by the vendor. Attackers exploit these vulnerabilities before the software maker releases a fix.");
           
            answers.Add("An insider threat involves a current or former employee, contractor, or business partner who intentionally or unintentionally causes harm to an organization’s security, often by stealing or exposing sensitive data.");
           
            answers.Add("A drive-by download attack occurs when a user unknowingly downloads malware by visiting a compromised website, with the malware being downloaded and executed automatically without the user's consent.");
           
            answers.Add("Social engineering involves manipulating individuals into divulging confidential information by exploiting trust, fear, or other psychological triggers, often through phone calls, emails, or in-person interaction.");
           
            answers.Add("In a supply chain attack, cybercriminals compromise software or hardware providers to gain access to their clients, targeting smaller companies in the supply chain with weaker security defenses as a backdoor to larger targets.");
           
          

        }//end of store answers

        //method for store ignore
        private void store_mize() {


            mize.Add("tell");
            mize.Add("me");
            mize.Add("what");
            mize.Add("is");
            mize.Add("educate");
            mize.Add("how are you ?");
            mize.Add("name");
            mize.Add("more");
        }
    }
}



