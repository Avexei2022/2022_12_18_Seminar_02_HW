// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int number = 0;
Console.Write("Введите трехзначное число: ");
int.TryParse(Console.ReadLine(), out number);
while (number < 100 | number > 999)
{
    Console.WriteLine("Условия ввода не выполнены.");
     Console.Write("Повторите ввод числа: ");
     int.TryParse(Console.ReadLine(), out number);
}

Console.WriteLine($"Вторая цифра числа {number} -> {(number%100 - number%10) / 10}");
Console.WriteLine("");

