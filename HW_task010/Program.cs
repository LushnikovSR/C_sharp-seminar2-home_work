// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.Clear();
Console.Write("Введите трёхзначное целое число: ");
string num = Console.ReadLine();
if (num.Length == 3)
{
    string signSecond = Convert.ToString(num[1]);
    Console.WriteLine($"{num} -> {signSecond}");
}
else
{
    Console.WriteLine($"Введено неверное число");
    Console.WriteLine("Введите трёхзначное целое число");
    Console.WriteLine("Например: 748");
}
