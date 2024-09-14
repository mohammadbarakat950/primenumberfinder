using System;

class primenumberfinder
{
    static bool isprime(int num)
    {
        if (num == 1)
            return false;

        for (int i = 2; i <= num/2; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    public static void NewGame()
    {
        Console.WriteLine("enter a number to check if its prime:");

        int number = int.Parse(Console.ReadLine());

        if (isprime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");

        }
    }

    static void Main(string[] args)
    {
        for (int i = 0; i <= 10; i++)
        {
            NewGame();
        }
    }


}






             