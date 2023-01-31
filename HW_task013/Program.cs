// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{
    // string textNumber = Convert.ToString(num);
    // string signThird = Convert.ToString(textNumber[2]);
    string signThird = Convert.ToString(Convert.ToString(num)[2]);
    Console.WriteLine($"{num} -> третья цифра {signThird}");
}