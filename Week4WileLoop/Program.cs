


Random rnd = new Random();

int cpuRandom = rnd.Next(1, 4);

bool loopActive = true;

int numberOfTrue = 0;

while (numberOfTrue < 3)
{
    Console.WriteLine("Try to guess the cpu number:");
    int userGuess = Convert.ToInt32(Console.ReadLine());

    numberOfTrue++;

    if (userGuess == cpuRandom)
    {
        Console.WriteLine("YOU WON Iphone15 :D");
        break;
    }

}
Console.WriteLine($"number of trues: {numberOfTrue}");
Console.WriteLine("Have a nice day");