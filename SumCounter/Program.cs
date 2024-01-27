int a, b;
if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine($"result: {a + b}");
}
else
{
    Console.WriteLine("Error with input values");
}
