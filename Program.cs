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
            /*
            string heart = "■";
            string heartLost = "□";
            string[] words = ["asztal", "szék", "lámpa", "ajtó", "ablak", "toll", "füzet", "ceruza", "könyv", "kulcs","óra", "telefon", "tükör","számítógép", "egér", "klaviatúra", "képernyő", "hűtő", "tűzhely", "kanapé","gyümölcs", "zöldség", "kenyér", "tej", "víz", "kávé", "cukor", "só", "bors", "hús","hal", "tojás", "sajt", "vaj", "lekvár", "méz", "csokoládé", "palacsinta", "pogácsa", "kalács","város", "falu", "utca", "tér", "park", "erdő", "hegy", "tó", "folyó", "tenger"];
            bool run = true;
            while (run)
            {
                Console.WriteLine("asd");
                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(1, 50);
                Console.WriteLine(randomNumber);
            }
            */
            
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
                    ArrowEnter();
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
            Console.SetCursorPosition(10, 0);
            Console.Write("●");
        }
        static void ArrowUp()
        {
            if (position != 0)
            {
                Console.SetCursorPosition(10, position);
                position--;
                Console.Write(" ", 1);
                Console.SetCursorPosition(10, position);
                Console.WriteLine("●");
            }
            
        }
        static void ArrowDown()
        {
            if (position != options.Length-1)
            {
                Console.SetCursorPosition(10, position);
                position++;
                Console.Write(" ", 1);
                Console.SetCursorPosition(10, position);
                Console.WriteLine("●");
            }
            
        }
        static void ArrowEnter()
        {
            
        }
        
    }

}