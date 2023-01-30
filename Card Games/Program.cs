Random rnd = new Random();
int scoreOne = 0;
int scoreTwo = 0;
bool isGameRunning = true; 

while (isGameRunning)
{
    int playerOne = rnd.Next(1, 14);
    int playerTwo = rnd.Next(1, 14);

    Console.WriteLine("One...\nTwo...\nThree...\nDRAW!\n");
    Console.WriteLine($"Player One: {playerOne}\nPlayer Two: {playerTwo}");

    if (playerOne > playerTwo)
    {
        Console.WriteLine("Player One wins!");
        scoreOne++;
    }
    else if (playerOne < playerTwo)
    {
        Console.WriteLine("Player Two wins!");
        scoreTwo++;
    }
    else if (playerOne == playerTwo)
    {
        Console.WriteLine("It's a tie!");
    }

    Console.WriteLine($"Score: {scoreOne} - {scoreTwo}\n");
    Console.WriteLine("Would you like to play again? (Y/N):");

    string continueValue = Console.ReadLine().Trim().ToUpper();
    if (continueValue == "Y")
    {
        isGameRunning = true;
    }
    else if (continueValue == "N")
    {
        isGameRunning = false;
    }
    else if (continueValue != "Y" || continueValue != "N")
    {
        Console.WriteLine("Input Y or N:");
        continueValue = Console.ReadLine().Trim().ToUpper();
    }
}

if (!isGameRunning)
{
    Console.WriteLine($"Thanks for playing! Final score: {scoreOne} - {scoreTwo}");
}