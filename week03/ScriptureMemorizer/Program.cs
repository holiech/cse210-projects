using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("Scripture Memorizer!");
        Console.WriteLine();

        Reference reference1 = new Reference("John", 3, 16);
        string scriptureText1 = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        
        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        string scriptureText2 = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        Reference reference3 = new Reference("Philippians", 4, 13);
        string scriptureText3 = "I can do all this through him who gives me strength."; 

        Reference reference4 = new Reference("Psalm", 23, 1);
        string scriptureText4 = "The Lord is my shepherd, I lack nothing."; 

        Reference reference5 = new Reference("Romans", 8, 28);
        string scriptureText5 = "And we know that in all things God works for the good of those who love him, who have been called according to his purpose.";  

        Reference reference6 = new Reference("Isaiah", 41, 10);
        string scriptureText6 = "So do not fear, for I am with you; do not be dismayed, for I am your God. I will strengthen you and help you; I will uphold you with my righteous right hand.";

        Reference reference7 = new Reference("Matthew", 6, 33);
        string scriptureText7 = "But seek first his kingdom and his righteousness, and all these things will be given to you as well."; 
        
        Reference reference8 = new Reference("Jeremiah", 29, 11);
        string scriptureText8 = "For I know the plans I have for you, declares the Lord, plans to prosper you and not to harm you, plans to give you hope and a future.";   

        Reference reference9 = new Reference("2 Timothy", 1, 7);
        string scriptureText9 = "For the Spirit God gave us does not make us timid, but gives us power, love and self-discipline.";

        Reference reference10 = new Reference("Psalm", 46, 1);
        string scriptureText10 = "God is our refuge and strength, an ever-present help in trouble.";

        Scripture[] scripture = new Scripture []
        {
            new Scripture(reference1, scriptureText1),
            new Scripture(reference2, scriptureText2),
            new Scripture(reference3, scriptureText3),
            new Scripture(reference4, scriptureText4),
            new Scripture(reference5, scriptureText5),
            new Scripture(reference6, scriptureText6),
            new Scripture(reference7, scriptureText7),
            new Scripture(reference8, scriptureText8),
            new Scripture(reference9, scriptureText9),
            new Scripture(reference10, scriptureText10)
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Display all scripture references");
            Console.WriteLine("2. randomly select a scripture to work on");
            Console.WriteLine("3. Quit");
            Console.WriteLine();

            string choice = Console.ReadLine().ToLower();
            if (choice == "1")
            {
                Console.WriteLine("Available References:");
                foreach (Scripture s in scripture)
                {
                    Console.WriteLine(s.Reference.ToString());
                }

                Console.WriteLine("press Enter to return to the main menu....");
                Console.ReadLine();
            }
            
            else if (choice == "2")
            {
                Random random = new Random();

                Scripture selectedScripture = scripture[random.Next(scripture.Length)];

                selectedScripture.DisplayScripture();
                Console.WriteLine("Please Enter to begin memorizing the scripture");
                Console.ReadLine();

                Console.WriteLine("Press Enter to continue or type 'quit' to exit");

                while (!selectedScripture.AllWordsHidden())
                {
                    string input = Console.ReadLine();
                    if (input.ToLower() == "quit")
                    {
                        break;
                    }

                    selectedScripture.HideWords(3);
                    selectedScripture.DisplayScripture();
                    Console.WriteLine("Press Enter to continue or type 'quit' to exit.");   
                
                }

                if (selectedScripture.AllWordsHidden())
                {
                    Console.WriteLine("Congratulations! You have memorized the scripture.");
                    Console.WriteLine("press Enter to return to the main menu....");
                    Console.ReadLine();
                    
                }
            }
            else if (choice == "3")

            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
                
        }   
    }
 } 