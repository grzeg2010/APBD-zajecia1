// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

for (var i = 0; i < 50; i++)
{
    Console.WriteLine(i);
}

List<char> letters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

letters.ForEach(letter => Console.WriteLine(letter));