// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("Greetings, what is your name?");
string name = Console.ReadLine();

Console.WriteLine("Hello " + name + ", please pick an interger from 1-100");
int userIntChoice = int.Parse(Console.ReadLine());
if (userIntChoice < 1 || userIntChoice > 100)
{
    Console.WriteLine("Please enter a valid interger " + name);
    return;
}
else if (userIntChoice % 2 != 0 && userIntChoice < 60)
{
    Console.WriteLine(name + ", Your number is odd and less than 60.");
}
else if (userIntChoice % 2 == 0 && userIntChoice < 25)
{
    Console.WriteLine(name + ", your number is even and less than 25");
}
else if (userIntChoice % 2 == 0 && userIntChoice >= 26 && userIntChoice <= 60)
{
    Console.WriteLine(name + ", your number is even and between 26 and 60 inclusive.");
}
else if (userIntChoice % 2 == 0 && userIntChoice > 60)
{
    Console.WriteLine(name + ", your number is even and greater than 60");
}
else if (userIntChoice % 2 != 0 && userIntChoice > 60)
{
    Console.WriteLine(name + ", your number is odd and greater than 60");
}