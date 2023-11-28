namespace Games
{
    class Round
    {
        public static readonly string[] actionsArr = ["rock", "paper", "scissors"];

        public string Winner = "";

        private string GenerateAction()
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(0, 3);
            Console.WriteLine($"Computer: {actionsArr.GetValue(randomNum)}");
            return (string)actionsArr.GetValue(randomNum)!;
        }

        private string GetSetAction()
        {
            Console.WriteLine("Input your move of (rock/paper/scissors)");
            string input = Console.ReadLine()!;
            if (actionsArr.Contains(input))
            {
                Console.WriteLine($"Player: {input}");
                return input;
            }
            else
            {
                Console.WriteLine("ERROR: --> Please enter either [rock] or [paper] or [scissors]");
                return GetSetAction();
            }

        }

        public string CalcualteWinner()
        {
            string player = GetSetAction();
            string computer = GenerateAction();

            if (player == computer)
            {
                Console.WriteLine("Draw!");
                return "draw";
            }
            else if ((player == "rock" && computer == "scissors")
                || (player == "scissors" && computer == "paper")
                || (player == "paper" && computer == "rock"))
            {
                Console.WriteLine("Player wins!");
                return "player";
            }
            else if ((computer == "rock" && player == "scissors")
                || (computer == "scissors" && player == "paper")
                || (computer == "paper" && player == "rock"))
            {
                Console.WriteLine("Computer wins!");
                return "computer";
            }
            else
            {
                Console.WriteLine("Forgot one!");
                return "error";
            }
        }
        public Round()
        {
            Winner = CalcualteWinner();
        }
    }

    class Controller
    {
        public static void EndGame()
        {
            Console.WriteLine("Press ESC to cancel or ENTER to play another round");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == 27)
            {
                Console.Write("\nTThanks for playing!");
                Environment.Exit(0);
            }
            else if (info.KeyChar == 13)
            {
                RockPaperScissors.Rounds++;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERROR: --> Please press either [ESC] or [ENTER] keys");
                EndGame();
            }
        }
        //public static string GetInput()
        //{
        //    Console.WriteLine("Input your move of (rock/paper/scissors)");
        //    string input = Console.ReadLine()!;
        //    if (Round.actionsArr.Contains(input))
        //    {
        //    return input;
        //    }
        //    else
        //    {
        //        Console.WriteLine("ERROR: --> Please enter either [rock] or [paper] or [scissors]");
        //        return "";
        //    }
        //}
    }

    internal class RockPaperScissors
    {
        public static List<Round> roundsList = new List<Round>();

        public static int Rounds = 1;


        public static void StartGame()
        {
            for (int i = 0; i < Rounds; i++)
            {
                Console.WriteLine($"### START ROUND {i + 1} ###");
                Round round = new Round();
                roundsList.Add(round);
                Console.WriteLine($"List winner: {roundsList[i].Winner}");
                Console.WriteLine($"### END ROUND {i + 1} ###");
                Controller.EndGame();
            }
        }
    }
}
