// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели: ");
int numDay = int.Parse(Console.ReadLine());
if (numDay < 1 || numDay > 7)
{
    Console.WriteLine("Введено не корректное число");
    Console.WriteLine("Введите цифру от 1 до 7");
}
else if (numDay > 0 && numDay < 6)
{
    Console.WriteLine($"{numDay} -> нет");
}
else if (numDay > 5 && numDay < 8)
{
    Console.WriteLine($"{numDay} -> да");
}