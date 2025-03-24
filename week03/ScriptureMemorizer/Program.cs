using System;
using System.Collections.Generic;

class Program
{
    static List<Scripture> scriptureLibrary = new List<Scripture>();

    static void Main(string[] args)
    {
        // Initialize the scripture library
        InitializeScriptureLibrary();

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Random random = new Random();
        bool quit = false;

        while (!quit)
        {
            var unmemorizedScriptures = scriptureLibrary.FindAll(s => !s.GetIsMemorized());
            if (unmemorizedScriptures.Count == 0)
            {
                Console.WriteLine("Congratulations! You've memorized all scriptures.");
                break;
            }

            Scripture randomScripture = unmemorizedScriptures[random.Next(unmemorizedScriptures.Count)];

            while (!randomScripture.IsCompletelyHidden())
            {
                // Clear the console and display the scripture
                Console.Clear();
                Console.WriteLine(randomScripture.GetDisplayText());

                Console.Write("Press Enter to hide random words or type 'quit' to exit: ");
                string input = Console.ReadLine();

                // Quit or continue?
                if (input.ToLower() == "quit")
                {
                    quit = true;
                    break;
                }

                // Hide random words
                randomScripture.HideRandomWords(random);
            }

            // Display the scripture with all words revealed
            Console.Clear();
            randomScripture.RevealAllWords();
            Console.WriteLine(randomScripture.GetDisplayText());
            Console.WriteLine("Congratulations! You've memorized this scripture.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    static void InitializeScriptureLibrary()
    {
        // Add scriptures to the library
        scriptureLibrary.Add(new Scripture("Mosiah", 2, 28, "And now, it shall be a testimony for you of the things of God; it shall be a witness unto you of my words; and may God bless you, and keep you, and bring you to the knowledge of Him who is our Redeemer."));
        scriptureLibrary.Add(new Scripture("Mosiah", 3, 19, "For behold, and also his blood atoneth for the sins of those who have fallen by the transgression of Adam, who have died not knowing the will of God concerning them, or who have ignorantly sinned."));
        scriptureLibrary.Add(new Scripture("Mosiah", 4, 11, "And again, believe that ye must repent of your sins and be baptized in the name of Jesus Christ; and by the baptism of fire ye shall be cleansed from all your sins."));
        scriptureLibrary.Add(new Scripture("Mosiah", 4, 16, "And behold, I say unto you that if ye do this ye shall always rejoice, and be filled with the love of God, and always retain a remission of your sins; and ye shall grow in the knowledge of the glory of him who created you, or in the knowledge of that which is just and true."));
        scriptureLibrary.Add(new Scripture("Mosiah", 4, 27, "And may the Lord bless you, and keep your garments spotless, that ye may at last be brought to sit down with Abraham, Isaac, and Jacob, and the holy prophets who have been ever since the world began, having your garments spotless even as their garments are spotless in the kingdom of heaven to go no more out."));
        scriptureLibrary.Add(new Scripture("Proverbs", 3, 5, "Trust in the Lord with all thine heart; and lean not unto thine own understanding."));
        scriptureLibrary.Add(new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        scriptureLibrary.Add(new Scripture("Mosiah", 2, 2, 3, "And they all cried with one voice, saying: Yea, we believe all the words which thou hast spoken unto us; and also, we know of their surety and truth, because of the Spirit of the Lord Omnipotent, which has wrought a mighty change in us, or in our hearts, that we have no more disposition to do evil, but to do good continually."));
        scriptureLibrary.Add(new Scripture("Mosiah", 2, 4, 6, "And again he saith: If my people shall keep my commandments, and walk in the paths of righteousness, I will establish my church among them, and they shall come forth out of darkness into light, according to the word. And now, behold, I say unto you, and I say it unto you with an exceeding great joy, my beloved brethren, that I have somewhat to declare unto you."));
    }
}
