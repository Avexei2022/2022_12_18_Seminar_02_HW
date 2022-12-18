// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int number = 0;
Console.Write("Введите целое число от 1 до 1 000 000 000: ");
int.TryParse(Console.ReadLine(), out number);

while (number < 1 | number > 1000000000)
{
     Console.WriteLine("Условия ввода не выполнены.");
     Console.Write("Повторите ввод числа: ");
     int.TryParse(Console.ReadLine(), out number);
}

if (number < 100) Console.Write($"В числе {number} третьей цифры нет.");
else
{
    int count = 10;
    while ((number - number%count) > 0) count = count * 10;
    if (count == 1000)
    {
        int digit = number%(count/100);
        Console.WriteLine($"Третья цифра в числе {number} -> {digit}");
    }
    else
    {
        int digit = (number%(count/100)-number%(count/1000))/(count/1000);
        Console.WriteLine($"Третья цифра в числе {number} -> {digit}");
    }
}
Console.WriteLine("");
