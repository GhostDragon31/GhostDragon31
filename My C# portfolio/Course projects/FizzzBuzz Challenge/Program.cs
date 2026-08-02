//FizzBuzz Challenge
/*This was a fun challenge where you had to print out numbers from 1 to 100.
Any number that was dividable by 3 was Fizz, any diviable by 5 was Buzzz.
Any number that was diviable by both 3 and 5 was FizzBuzz. Great challenge!*/

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 ==0))
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}Console.WriteLine("Hello, World!");
