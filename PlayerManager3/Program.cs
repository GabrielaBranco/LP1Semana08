using System;
using System.Collections.Generic;

namespace PlayerManager3
{
    /// The player listing program.
    public class Program
    {
        /// The list of all players.
        private List<Player> playerList;

        /// Program begins here.
        private static void Main()
        {
            // Create a new instance of the player listing program
            Program prog = new Program();
            // Start the program instance
            prog.Start();
        }

        /// Creates a new instance of the player listing program.
        private Program()
        {
            // Initialize the player list with two players using collection
            // initialization syntax
            playerList = new List<Player>()
            {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
        }

        /// Start the player listing program instance
        private void Start()
        {
            // We keep the user's option here
            string option;

            // Main program loop
            do
            {
                // Show menu and get user option
                ShowMenu();
                option = Console.ReadLine();

                // Determine the option specified by the user and act on it
                switch (option)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        playerList.Sort();
                        ListPlayers(playerList);
                        break;
                    case "3":
                        Console.WriteLine("Set a minimum score value: ");
                        int minScore = int.Parse(Console.ReadLine());
                        ListPlayersWithScoreGreaterThan(playerList, minScore);
                        break;
                    case "4":
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
                        break;
                }

                // Wait for user to press a key...
                Console.Write("\nPress any key to continue...");
                Console.Read();
                Console.WriteLine("\n");

                // Loop keeps going until players choses to quit (option 4)
            } while (option != "4");
        }

        private void ShowMenu()
        {
            Console.WriteLine
            ("1. Add new player \n2. List of players" +
            "\n3. List players with a score higher then a user-specified value" +
            "\n4. EXIT");
        }

        private void InsertPlayer()
        {
            Console.WriteLine("Your name:");
            string playerName = Console.ReadLine();
            Console.WriteLine("Your score:");
            string score = Console.ReadLine();
            int playerScore = int.Parse(score);

            playerList.Add(new Player(playerName, playerScore));
        }

        private static void ListPlayers(IEnumerable<Player> playersToList)
        {
            foreach (Player p in playersToList)
            {
                Console.WriteLine($"{p.Name}: {p.Score}");
            }
        }

        /// Show all players with a score higher than a user-specified value.
        private void ListPlayersWithScoreGreaterThan(IEnumerable<Player> playersList, int minScore)
        {
            IEnumerable<Player> newPlayerList = GetPlayersWithScoreGreaterThan(minScore);

            Console.WriteLine($"\nPlayer with a score higher than {minScore}:\n");

            foreach (var p in newPlayerList)
            {
                Console.WriteLine($"Name: {p.Name}, Score: {p.Score}");
            }
        }

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            foreach (Player p in playerList)
            {
                if (p.Score >= minScore)
                {
                    yield return p;
                }
            }
        }
    }
}