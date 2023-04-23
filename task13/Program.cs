// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string num = Convert.ToString(Console.ReadLine());
if (num.Length >= 3)
{
    char char3 = num[2];
    Console.WriteLine(char3);
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}