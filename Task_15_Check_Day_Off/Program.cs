// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int number = 0;
Console.Write("Введите цифру дня недели с отсчетом от понедельника: ");
int.TryParse(Console.ReadLine(), out number);

while (number < 1 | number > 365)
{
    Console.WriteLine("Таких цифр в году нет.");
     Console.Write("Повторите ввод: ");
     int.TryParse(Console.ReadLine(), out number);
}
int number1 = 0;
if (number < 7) number1 = number + 7;
else number1 = number;
if (number1 % 7 == 0 || number1 % 7 == 6)
{
    Console.WriteLine($"День недели {number} с отсчетом от понедельника будет выходным днем.");
    Console.WriteLine($"{number} -> Да");
}
else
{
    Console.WriteLine($"День недели {number} с отсчетом от понедельника не является выходным днем.");
    Console.WriteLine($"{number} -> Нет");
}
Console.WriteLine("");