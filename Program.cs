using System;

namespace GallowsGAme
{
    class Program
    {
        static int position = 0;
        static string[] options = {"Játék", "Kilépés"};
        static bool run = true;
        
        static void Main(string[] args)
        {
            RunMenu();
        }
        
        static void RunMenu()
        {
            DrawMenu();
            ConsoleKeyInfo pressedKey;
            do
            {
                pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    ArrowUp();
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    ArrowDown();
                }
                else if (pressedKey.Key == ConsoleKey.Enter)
                {
                    Enter();
                }
            } while (run);
        }
        
        static void DrawMenu()
        {
            Console.Clear();
            Console.CursorVisible = false;
            for (int a = 0; a < options.Length; a++)
            {
                Console.WriteLine($"{options[a]}");
            }
            Console.SetCursorPosition(options[position].Length + 2, 0);
            Console.Write("●");
        }
        
        static void ArrowUp()
        {
            if (position != 0)
            {
                Console.SetCursorPosition(options[position].Length + 2, position);
                position--;
                Console.Write(" ", 1);
                Console.SetCursorPosition(options[position].Length + 2, position);
                Console.WriteLine("●");
            }
        }
        
        static void ArrowDown()
        {
            if (position != options.Length - 1)
            {
                Console.SetCursorPosition(options[position].Length + 2, position);
                position++;
                Console.Write(" ", 1);
                Console.SetCursorPosition(options[position].Length + 2, position);
                Console.WriteLine("●");
            }
        }
        
        static void Enter()
        {
            switch (position)
            {
                case 0:
                    Console.Clear();
                    Game();
                    break;
                case 1:
                    Console.Clear();
                    Console.CursorVisible = true;
                    run = false;
                    break;
            }
        }
        static void Game()
        {
            string heart = "■";
            string heartLost = "□";
            string life = "Élet:";
            int lineNullLength = life.Length;
            int lineOneLength = 0;
            int heartCounter = 10;
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 50);
            string[] words = ["asztal", "szék", "lámpa", "ajtó", "ablak", "toll", "füzet", "ceruza", "könyv", "kulcs","óra", "telefon", "tükör","számítógép", "egér", "klaviatúra", "képernyő", "hűtő", "tűzhely", "kanapé","gyümölcs", "zöldség", "kenyér", "tej", "víz", "kávé", "cukor", "só", "bors", "hús","hal", "tojás", "sajt", "vaj", "lekvár", "méz", "csokoládé", "palacsinta", "pogácsa", "kalács","város", "falu", "utca", "tér", "park", "erdő", "hegy", "tó", "folyó", "tenger"];
            string randomWord = words[randomNumber];
            bool runGame = true;
            Console.Write($"{life}");
            
            for (int a = 0; a < heartCounter; a++)
            {
                Console.Write($" {heart}");
                lineNullLength = lineNullLength + 2;
            }
            
            Console.WriteLine("");
            
            for (int a = 0; a < words[randomNumber].Length; a++)
            {
                Console.Write("_ ");
                lineOneLength = lineOneLength + 2;
            }
            
            while (runGame)
            {
                Console.CursorVisible = true;
                int a = 0;
                // lineNullLength = lineNullLength - 2;
                // Console.SetCursorPosition(lineNullLength, 0);
                // Console.Write($" {heartLost}");
                // Console.WriteLine("");
                tipDraw();
                string tip = Console.ReadLine();
                if (tip.Length != 1)
                {
                    invalidInput();
                }
                else
                {
                    bool insideOrNot = false;
                    a = 0;
                    while (insideOrNot != true && randomWord.Length != a)
                    {
                        if (tip[0] == randomWord[a])
                        {
                            insideOrNot = true;
                            CorrectCharPrint();
                            break;
                        }
                        a++;
                    }
                    if (insideOrNot == false)
                    {
                        MinusHeart();
                    }
                }
                
                void CorrectCharPrint()
                {
                    
                }
                void MinusHeart()
                {
                    heartCounter--;
                    lineNullLength = lineNullLength - 2;
                    Console.SetCursorPosition(lineNullLength, 0);
                    Console.Write($" {heartLost}");
                }
                void invalidInput() { 
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(0, 3);
                    for (int b = 0; b < 44; b++)
                    {
                        Console.Write(" ");
                    }
                    Console.SetCursorPosition(0, 3);
                    Console.Write("Legalább egy, de annál több betűt ne írj be.");
                    Thread.Sleep(2000);
                    Console.SetCursorPosition(0, 3);
                    for (int b = 0; b < 44; b++)
                    {
                        Console.Write(" ");
                    }
                    Console.SetCursorPosition(0, 3);
                    Console.CursorVisible = true;
                }
                void tipDraw() 
                {
                    Console.SetCursorPosition(0, 3);
                    for (int b = 0; b < 44; b++)
                    {
                        Console.Write(" ");
                    }
                    Console.SetCursorPosition(0, 3);
                    Console.Write("Tipp: ");
                    Console.SetCursorPosition(6, 3);
                }
                if (heartCounter == 0) 
                {
                    runGame = false;
                }
            }
        }
    }
}