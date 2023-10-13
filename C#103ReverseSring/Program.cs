string forward, backwards = "";

Console.Write("Enter a string: ");
forward = Console.ReadLine();



for (int i = forward.Length - 1; i >= 0; i--)
{
    backwards += forward[i];
}

Console.WriteLine($"Reversed is {backwards}");