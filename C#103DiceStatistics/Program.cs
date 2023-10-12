int arrayTotal;

do
{
    Console.Write("How many numbers: ");
    if (int.TryParse(Console.ReadLine(), out arrayTotal))
    {
        if (arrayTotal > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("The number must be positive.");
        }
    }
    else
    {
        Console.WriteLine("That is not a valid number.");
    }
} while (true);

int[] numberArray = new int[arrayTotal];
Random random = new Random();
int numberLow = 1000;
int numberHigh = -1000;
double numberSum = 0;

for (int i = 0; i < numberArray.Length; i++)
{
    numberArray[i] = random.Next(-1000, 1000);
    numberSum += numberArray[i];
    if (numberArray[i] < numberLow )
    {
        numberLow = numberArray[i];
    }
    else if (numberArray[i] > numberHigh )
        {
        numberHigh = numberArray[i];
    }
}

Console.WriteLine($"Total Numbers {numberArray.Length}");
Console.WriteLine($"Low: {numberLow}");
Console.WriteLine($"High: {numberHigh}");
Console.WriteLine($"Average: {Math.Round(numberSum / numberArray.Length, 2)}");