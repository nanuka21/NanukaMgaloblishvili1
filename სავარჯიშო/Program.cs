

Console.WriteLine("Welcome to our game,which is about guessing numbers");
Console.WriteLine("You have 3 tries, please enter the number if it matches the number we guessed you win otherwise unfortunately you lose");
Console.WriteLine("Please enter the number > ");

Random random = new Random();
int randomNumber = random.Next (1, 11);
int Numberoftries = 3;

for (int i = 0; i < Numberoftries; i++)
{
    Console.Write($"Attemp {i + 1}:");
    int userGuess = int.Parse(Console.ReadLine());

    if (userGuess == randomNumber)
    {
        Console.WriteLine("Congretulation ,you won!");
        break;
    }
    else

        Console.WriteLine("Sorry , you lost Try again:(");

    {
        if (userGuess != randomNumber)
            Console.WriteLine("you lose Finally bye bye the correct number was{randomNumber}.")
;
    }
}
    