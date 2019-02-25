using System;

namespace MonsterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRandom = new Random();
            DisplayWelcomeScreen("Monsters", "Micah Thoreson", "displays monsters");
            SeaMonster mySeaMonster;
            SpaceMonster mySpaceMonster;

            mySeaMonster = InitializeSeaMonster(myRandom);
            mySpaceMonster = InitializeSpaceMonster(myRandom);
            DisplayMenu(mySeaMonster, mySpaceMonster);
            DisplayClosingScreen();
        }

        static SeaMonster InitializeSeaMonster(Random myRandom)
        {

            return new SeaMonster()
            {
                Id = 1,
                Name = "Suzy",
                Age = 473,
                HasGills = true,
                HomeSea = "Baltic Sea",
                Toughness = 10 + myRandom.Next(0, 101),
                Ferociousness = 5 + myRandom.Next(0, 101),
                Fishy = myRandom.Next(0, 101)
            };
        }

        static SpaceMonster InitializeSpaceMonster(Random myRandom)
        {
            return new SpaceMonster()
            {
                Id = 1,
                Name = "Sid",
                Age = 18,
                Galaxy = "Andromeda",
                Toughness = 5 + myRandom.Next(0, 101),
                Ferociousness = 10 + myRandom.Next(0, 101),
                Spacey = myRandom.Next(0, 101)
            };
        }

        static void DisplayMenu(SeaMonster mySeaMonster, SpaceMonster mySpaceMonster)
        {
            bool exitMenu = false;
            int menuSelection;

            do
            {
                Console.Clear();
                DisplayHeader("Menu");
                Console.WriteLine("1) Display Monsters");
                Console.WriteLine("2) Exit");
                Console.WriteLine();
                Console.Write("Enter Selection:");
                menuSelection = int.Parse(Console.ReadLine());

                switch (menuSelection)
                {
                    case 1:
                        DisplayMonsterInfoScreen(mySeaMonster, mySpaceMonster);
                        break;
                    case 2:
                        exitMenu = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a proper selection.");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!exitMenu);

        }

        static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster)
        {
            DisplayHeader("Monster Info");
            Console.WriteLine("Sea Monster");
            DisplaySeaMonsterInfo(seaMonster);

            Console.WriteLine();
            Console.WriteLine("Space Monster");
            DisplaySpaceMonsterInfo(spaceMonster);

            DisplayContinuePrompt();
        }

        private static void DisplaySpaceMonsterInfo(SpaceMonster spaceMonster)
        {
            Console.WriteLine($"Id: {spaceMonster.Id}");
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine($"Age: {spaceMonster.Age}");
            Console.WriteLine($"Galaxy: {spaceMonster.Galaxy}");
            Console.WriteLine($"Is Happy: {(spaceMonster.IsHappy() ? "yes" : "no") }");
            Console.WriteLine($"Toughness: {spaceMonster.Toughness}");
            Console.WriteLine($"Ferociousness: {spaceMonster.Ferociousness}");
            Console.WriteLine($"{(spaceMonster.IsTough() ? "I am very tough" : "I am not very tough")}");
            Console.WriteLine($"You attacked {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponse()}");
        }

        private static void DisplaySeaMonsterInfo(SeaMonster seaMonster)
        {
            Console.WriteLine($"Id: {seaMonster.Id}");
            Console.WriteLine($"Name: {seaMonster.Name}");
            Console.WriteLine($"Age: {seaMonster.Age}");
            Console.WriteLine($"Home Sea: {seaMonster.HomeSea}");
            Console.WriteLine($"Has Gills: {seaMonster.HasGills}");
            Console.WriteLine($"Is Happy: {seaMonster.IsHappy()}");
            Console.WriteLine($"Toughness: {seaMonster.Toughness}");
            Console.WriteLine($"Ferociousness: {seaMonster.Ferociousness}");
            Console.WriteLine($"{(seaMonster.IsTough() ? "I am very tough" : "I am not very tough")}");
            Console.WriteLine($"{seaMonster.Name} is attacked and {(seaMonster.MonsterBattleHurt() ? "is hurt" : "is not hurt")}");
        }

        static void DisplayWelcomeScreen(string title, string author, string purpose)
        {
            Console.Clear();
            Console.WriteLine($"\t\tWelcome to {title}, \nby {author}");
            Console.WriteLine($"\nThis program {purpose}");
            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        static void DisplayClosingScreen()
        {
            Console.WriteLine("\n\t\tThank you for using my App.");
            DisplayContinuePrompt();
        }

        static void DisplayHeader(string headText)
        {
            Console.Clear();
            Console.WriteLine($"\n{headText}\n");
        }
    }
}
