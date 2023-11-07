namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {   // FIRST EXERCISE 
            bool youWon = false;
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number.");


            while (youWon == false)
            {
                var userInput = int.Parse(Console.ReadLine());
                string response = AnswerResponse(userInput, favNumber);
                Console.WriteLine(response);

                if (response == "YOU GOT IT")
                { youWon = true; }
            }
            // SECOND EXERCISE
            Console.WriteLine("TELL ME YOUR FAVORITE SUBJECT NOW!");
            var favSub = Console.ReadLine().ToLower();
            string finalResponse = RelayTheirFaveSubject(favSub);
            Console.WriteLine(finalResponse);


        }
        public static string RelayTheirFaveSubject(string favSub)
        {
            switch (favSub) 
            {
                case "history":
                    return "HISTORY SUCKS WHAT THE HECK?!?!";
                case "science":
                    return "Ugh, you would.";
                case "math":
                    return "HA nerd.  BYE";
                case "english":
                    return ".... sorry what?  I fell asleep...zzz";
                case "art":
                    return "Awww I used to love finger painting too... when I was a kid.";
                default:
                    return "Yeah I don't know what that is.  Peace.";
            }

        }








        public static string AnswerResponse(int userInput, int favNumber)
        {

            if (userInput < favNumber)
            {
                return "Your guess is too low - try again";
            }
            else if (userInput > favNumber)
            {
                return "Your guess is too high - try again";
            }
            else if (userInput == favNumber)
            {
                return "YOU GOT IT";
            }
            else
            {
                return "ERROR";
            }
        }


    }
}

