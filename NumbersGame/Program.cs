using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kristina Eriksson (.NET22)
            // The program is calling the MainMenu method
            MainMenu();
        }
        // The MainMenu method
        // Welcoming the user and ask the user to choose a alternative from the menu by write a number between 1 to 4. 
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till gissa nummret!");
            Console.WriteLine("Vänligen välj ett alternativ i menyn genom att skriva en siffra mellan 1-4 och bekräfta valet genom att trycka Enter: ");

            Console.WriteLine("1. Lätt ");
            Console.WriteLine("2. Medelsvårt");
            Console.WriteLine("3. Svårt");
            Console.WriteLine("4. Avsluta spelet");

            // The program is calling the CheckMenu method 
            CheckMenu();
        }

        // The PlayAgain method
        public static void PlayAgain()
        {
            // Ask the user to type in Y if they want to play again
            Console.WriteLine("\nVill du spela igen? [Y/N] ");
            // Variable holding the users input
            var keyPressed = Console.ReadKey();

            // Loop checking the users input
            if (keyPressed.Key == ConsoleKey.Y)
            {
                // If users input is Y,y user return to MainMenu
                MainMenu();
            }
            else
            {
                // If input is not Y,y, the program exits
                Console.Clear();
                Console.WriteLine("Programmet avslutas.");
                Environment.Exit(0);
            }
        }
        // The CheckMenu method
        // Depending on which input from the user, the program is writing out different degree of difficulty
        public static void CheckMenu()
        {
            // Generate a random number to the game
            Random random = new Random();
            // Holding the users input from the MainMenu
            int menuChoice = Convert.ToInt32(Console.ReadLine());

            // Write out first choice from the MainMenu
            if (menuChoice == 1)
            {
                Console.Clear();
                // Give the game a random number between 1 to 10
                int number = random.Next(1, 11);
                // Number of chances the user get 
                int numberOfGuesses = 6;

                // Welconming the user to the easy game and ask the user to guess a number
                Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 och 10, kan du gissa vilket?\nDu får 6 försök.\nAnge ett heltal:");
                // Calling the CheckGuesses method to check the users guess
                CheckGuesses(number, numberOfGuesses);
                // When the game is over, the program is calling the PlayAgain method
                PlayAgain();
            }
            // Write out the second choice from the MainMenu
            else if (menuChoice == 2)
            {
                Console.Clear();
                // Give the game a random number between 1 to 25
                int number = random.Next(1, 26);
                // Number of chances the user get
                int numberOfGuesses = 5;

                // Welcoming the user to the intermediate game and ask the user to guess a number
                Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 och 25, kan du gissa vilket?\nDu får 5 försök.\nAnge ett heltal:");
                // Calling the CheckGuesses method to check the users guess
                CheckGuesses(number, numberOfGuesses);
                // When the game is over, the program is calling the PlayAgain method
                PlayAgain();
            }
            // Write out the third choice from the MainMenu
            else if (menuChoice == 3)
            {
                Console.Clear();
                // Give the game a random number between 1 to 50
                int number = random.Next(1, 51);
                // Number of chances the user get
                int numberOfGuesses = 3;

                // Welcoming the user to the difficulty game and ask the user to guess a number
                Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 och 50, kan du gissa vilket?\nDu får 3 försök.\nAnge ett heltal:");
                // Calling the CheckGuesses method to check the users guess
                CheckGuesses(number, numberOfGuesses);
                // When the game is over, the program is calling the PlayAgain method
                PlayAgain();
            }
            // Write out the fourth choice from the MainMenu
            else if (menuChoice == 4)
            {
                // Exit the program
                Console.WriteLine("Programmet avslutas.");
                Environment.Exit(0);
            }
        }
        // The CheckGuesses method
        public static void CheckGuesses(int number, int numberOfGuesses)
        {
           // A boolean that contains a true or false statement if the game is over
           bool gameOver = false;
           // A variable holding the guesses
           int guess;
           // A temporary variable holding how many guesses the user has made
           int temp = numberOfGuesses;
            // A loop that will check if the users input is correct or wrong, the loop will repeat a different amount of times depending on which difficulty the user picked
            do
            {
                // A variable holding the users input
                guess = Convert.ToInt32(Console.ReadLine());
                // Counting down the guesses to zero
                numberOfGuesses--;

                // If statement with a condition
                if (guess != number && numberOfGuesses == 0)
                {
                    // If statement is true, write out a message to the user, that they have lost
                    Console.WriteLine("\nTyvärr, du lyckades inte gissa talet på " + temp + " försök!\nDet rätta talet var: " + number);
                    // Break the loop
                    break;
                }
                // If statement with a condition
                else if (guess == number)
                {
                    // If the statement is true, write out a message to the user that they have won
                    Console.WriteLine("\nWoho! Du gjorde det!\n"+number + " var rätt tal!");
                    // Break the loop
                    break;
                }
                // If statement with a condition
                else if (guess < number)
                {
                    // Write out a message to the user that their guess was too low, if the statement is true
                    Console.WriteLine("\nTyvärr, du gissade för lågt!\nDu har " + numberOfGuesses + " gissningar kvar, skriv ett heltal:");
                }
                // If statement with a condition
                else if (guess > number)
                {
                    // Write out a message to the user that their guess was too high if the statement is true
                    Console.WriteLine("\nTyvärr, du gissade för högt!\nDu har " + numberOfGuesses + " gissningar kvar, skriv ett heltal:");
                }
              // The game will repeat until the gameover statement is true
            } while (gameOver == false);
        }
    }
} 