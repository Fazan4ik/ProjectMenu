using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMenu
{
    delegate void MenuItem();
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem[] menuItems = {
            NewGame,
            LoadGame,
            ShowRules,
            ShowAuthorInfo,
            ExitGame
        };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t MENU");
                Console.WriteLine("\t1.New game");
                Console.WriteLine("\t2.Load game");
                Console.WriteLine("\t3.Rules");
                Console.WriteLine("\t4.About the author");
                Console.WriteLine("\t0.Exit");
                Console.Write("Select the menu item: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Incorrect input. Press any key to continue.");
                    Console.ReadKey();

                    continue;
                }

                if (choice < 0 || choice > menuItems.Length - 1)
                {
                    Console.WriteLine("Incorrect input. Press any key to continue.");
                    Console.ReadKey();

                    continue;
                }

                if (choice == 0)
                {
                    menuItems[4].Invoke();
                    break;
                }

                menuItems[choice - 1].Invoke();
            }
        }

        static void NewGame()
        {
            Console.WriteLine("New game...");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void LoadGame()
        {
            Console.WriteLine("Load game...");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void ShowRules()
        {
            Console.WriteLine("Game rules: No rules");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void ShowAuthorInfo()
        {
            Console.WriteLine("Author Info: Egor Safuanov");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void ExitGame()
        {
            Console.WriteLine("EXit with game...");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
