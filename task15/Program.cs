// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num < 6)
Console.WriteLine("нет");
else if (num > 5 && num < 8)
Console.WriteLine("да");
else 
Console.WriteLine("Не существует такого дня недели");