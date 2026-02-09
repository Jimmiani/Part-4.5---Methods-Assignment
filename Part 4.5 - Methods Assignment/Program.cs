namespace Part_4._5___Methods_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string choice, asciiChoice, knock1 = "", knock2 = "";
            bool done = false, asciiDone = false;
            int asciiX, asciiY;
            Console.SetBufferSize(200, 200);
            Console.SetWindowSize(150, 40);
            while (!done)
            {
                Console.SetCursorPosition(35, 2);
                Console.WriteLine("Welcome to my extremely cool menu screen for my methods programming assignment!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Here, you may choose which one of my incredible parts of the assignment to view.");
                Console.WriteLine("Option 1: ASCII Art");
                Console.WriteLine("Option 2: Knock Knock Joke");
                Console.WriteLine("Or, you can press '3' to exit the program.");
                Console.WriteLine();
                Console.Write("Pick your option (1, 2, or 3): ");
                choice = Console.ReadLine();
                while (choice != "1" && choice != "2" && choice != "3")
                {
                    Console.Write("Oops! Invalid Input! Try again: ");
                    choice = Console.ReadLine();
                }
                if (choice == "1")
                {
                    Console.Clear();
                    while (!asciiDone)
                    {
                        Console.WriteLine("Pick which ASCII you'd like to view:");
                        Console.WriteLine();
                        Console.WriteLine("Option 1: A tall cactus");
                        Console.WriteLine("Option 2: A short cactus");
                        Console.WriteLine("Option 3: A COWBOY CACTUS!!!");
                        Console.WriteLine("Or, you can press '4' to leave this section and return to the main menu.");
                        Console.WriteLine();
                        Console.Write("Pick your option (1, 2, 3, or 4): ");
                        asciiChoice = Console.ReadLine();
                        while (asciiChoice != "1" && asciiChoice != "2" && asciiChoice != "3" && asciiChoice != "4")
                        {
                            Console.Write("Oops! Invalid Input! Try again: ");
                            asciiChoice = Console.ReadLine();
                        }
                        if (asciiChoice == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Thanks for choosing the tall cactus! First, choose the X and Y coordinates you would like the cactus to be placed at.");
                            Console.WriteLine();
                            Console.Write("X coordinate: ");
                            while (!int.TryParse(Console.ReadLine(), out asciiX) || (asciiX < 0 || asciiX >= Console.BufferWidth))
                            {
                                Console.Write("Oops! Invalid Input! Value must be a number greater than zero and less than the window width. Try again: ");
                            }
                            Console.Write("Y coordinate: ");
                            while (!int.TryParse(Console.ReadLine(), out asciiY) || (asciiY < 0 || asciiY >= Console.BufferHeight))
                            {
                                Console.Write("Oops! Invalid Input! Value must be a number greater than zero and less than the window height. Try again: ");
                            }
                            Console.WriteLine("Okay! Press ENTER to see your cactus!");
                            Console.ReadLine();
                            Console.Clear();
                            DrawTallCactus(asciiX, asciiY);
                            Console.WriteLine();
                            Console.WriteLine("Pretty neat, huh! Press ENTER to return to ASCII selection screen");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (asciiChoice == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("Thanks for choosing the short cactus! First, choose the X and Y coordinates you would like the cactus to be placed at.");
                            Console.WriteLine();
                            Console.Write("X coordinate: ");
                            while (!int.TryParse(Console.ReadLine(), out asciiX) || (asciiX < 0 || asciiX >= Console.BufferWidth))
                            {
                                Console.Write("Oops! Invalid Input! Value must be a number greater than zero and less than the window width. Try again: ");
                            }
                            Console.Write("Y coordinate: ");
                            while (!int.TryParse(Console.ReadLine(), out asciiY) || (asciiY < 0 || asciiY >= Console.BufferHeight))
                            {
                                Console.Write("Oops! Invalid Input! Value must be a number greater than zero and less than the window height. Try again: ");
                            }
                            Console.WriteLine("Okay! Press ENTER to see your cactus!");
                            Console.ReadLine();
                            Console.Clear();
                            DrawShortCactus(asciiX, asciiY);
                            Console.WriteLine();
                            Console.WriteLine("Pretty neat, huh! Press ENTER to return to ASCII selection screen");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (asciiChoice == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("THANKS FOR CHOOSING THE COWBOY CACTUS!! First, choose the X and Y coordinates you would like the cactus to be placed at.");
                            Console.WriteLine();
                            Console.Write("X coordinate: ");
                            while (!int.TryParse(Console.ReadLine(), out asciiX) || (asciiX < 0 || asciiX >= Console.BufferWidth))
                            {
                                Console.Write("Oops! Invalid Input! Value must be a number greater than zero and less than the window width. Try again: ");
                            }
                            Console.Write("Y coordinate: ");
                            while (!int.TryParse(Console.ReadLine(), out asciiY) || (asciiY < 0 || asciiY >= Console.BufferHeight))
                            {
                                Console.Write("Oops! Invalid Input! Value must be a number greater than zero and less than the window height. Try again: ");
                            }
                            Console.WriteLine("Okay! Press ENTER to see your cactus!");
                            Console.ReadLine();
                            Console.Clear();
                            DrawCowboyCactus(asciiX, asciiY);
                            Console.WriteLine();
                            Console.WriteLine("DOESN'T IT LOOK SO COOL!?!?!??! Press ENTER to return to ASCII selection screen");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (asciiChoice == "4")
                        {
                            asciiDone = true;
                            Console.Clear();
                        }
                    }
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    KnockKnock(knock1, knock2);
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to return to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "3")
                {
                    done = true;
                }
                
            }
        }
        public static void DrawTallCactus(int x, int y)
        {
            List<string> cactus = new List<string>();
            cactus.Add("      ,`''',");
            cactus.Add("      ;' ` ;");
            cactus.Add("      ;`,',;");
            cactus.Add("      ;' ` ;");
            cactus.Add(" ,,,  ;`,',;");
            cactus.Add(";,` ; ;' ` ;   ,',");
            cactus.Add(";`,'; ;`,',;  ;,' ;");
            cactus.Add(";',`; ;` ' ; ;`'`';");
            cactus.Add(";` '',''` `,',`',;");
            cactus.Add(" `''`'; ', ;`'`'");
            cactus.Add("      ;' `';");
            cactus.Add("      ;` ' ;");
            cactus.Add("      ;' `';");
            cactus.Add("      ;` ' ;");
            cactus.Add("      ; ',';");
            cactus.Add("      ;,' ';");
            for (int i = 0; i < cactus.Count; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(cactus[i]);
            }
        }
        public static void DrawShortCactus(int x, int y)
        {
            List<string> cactus = new List<string>();
            cactus.Add("    ,*-.    ");
            cactus.Add("    |  |    ");
            cactus.Add(",.  |  |    ");
            cactus.Add("| |_|  | ,. ");
            cactus.Add("`---.  |_| |");
            cactus.Add("    |  .--` ");
            cactus.Add("    |  |    ");
            cactus.Add("    |  |    ");
            for (int i = 0; i < cactus.Count; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(cactus[i]);
            }
        }
        public static void DrawCowboyCactus(int x, int y)
        {
            List<string> cactus = new List<string>();
            cactus.Add(@"              _   _");
            cactus.Add(@"             / '-' \");
            cactus.Add(@"            ;       ;");
            cactus.Add(@"         /'-|       |-'\");
            cactus.Add(@"        |   |_______K   |");
            cactus.Add(@"        \   '-------'   /");
            cactus.Add(@"         '.___.....___.'");
            cactus.Add(@"            | ;  : ;|");
            cactus.Add(@"           _|;__;__.|_");
            cactus.Add(@"          |     Y     |    .--.");
            cactus.Add(@" .--.      \__.'^'.__/    /;   \");
            cactus.Add(@"/   ;\      |_  ;  _|     |  ' |");
            cactus.Add(@"| ;  |      { `^^^` }     |;   |");
            cactus.Add(@"|'   |      {       }     | ;  |");
            cactus.Add(@"|  ; |      {       }     |    |");
            cactus.Add(@"|;   |      ;`-.__.'|     |:  ;|");
            cactus.Add(@"| ;  \      |;  ;   |_____/ ;  |");
            cactus.Add(@"|   '.'-----'      ' -_   .'   /");
            cactus.Add(@"\  '.   - _  ' ;  ;  _  -    .'");
            cactus.Add(@" '.   -     - ;  ;   .------`");
            cactus.Add(@"   `--------.      ;|");
            cactus.Add(@"            |;  ,   |");
            cactus.Add(@"            |     ; |");
            cactus.Add(@"            |. ;    |");
            cactus.Add(@"            | :    :|");
            cactus.Add(@"            |   .   |");
            cactus.Add(@"            |;   ;  |");
            cactus.Add(@"            |;  ,   |");
            cactus.Add(@"            |     ; |");
            cactus.Add(@"            |. ;    |");
            cactus.Add(@"            | :    :|");
            cactus.Add(@"            |   .   |");
            cactus.Add(@"            |;   ;  |");
            cactus.Add(@"            |;  ,   |");
            cactus.Add(@"            |     ; |");
            cactus.Add(@"            |     ; |");
            cactus.Add(@"            |. ;    |");
            cactus.Add(@"            | :    :|");
            cactus.Add(@"            |   .   |");
            cactus.Add(@"            |;   ;  |");
            cactus.Add(@"            `^-----^`");
            for (int i = 0; i < cactus.Count; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(cactus[i]);
            }
        }
        public static void KnockKnock(string ans1, string ans2)
        {
            Console.WriteLine("Fred: Knock Knock!");
            Console.Write("You: ");
            ans1 = Console.ReadLine();
            while (ans1.ToLower() != "who's there?" && ans1.ToLower() != "who is there?" && ans1.ToLower() != "who's there" && ans1.ToLower() != "who is there" && (ans1.ToLower() != "whos there?" && ans1.ToLower() != "whos there"))
            {
                Console.WriteLine("Fred: YOU SAID THE WRONG LINE! Try again!");
                Console.Write("You: ");
                ans1 = Console.ReadLine();
            }
            Console.WriteLine("Fred: Europe");
            Console.Write("You: ");
            ans2 = Console.ReadLine();
            while (ans2.ToLower() != "europe who" && ans2.ToLower() != "europe who?")
            {
                Console.WriteLine("Fred: YOU SAID THE WRONG LINE! Try again!");
                Console.Write("You: ");
                ans2 = Console.ReadLine();
            }
            Console.WriteLine("Fred: No, you're a poo! HAHA!");
            Console.WriteLine("You: ...");
        }
    }
}
