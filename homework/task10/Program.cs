// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите 3-х значное число ");
int number = int.Parse(Console.ReadLine());

if (number < 100 || number > 999)
{
    System.Console.WriteLine("Число не 3-х значное. Повторите ввод");
}
else
{
   System.Console.WriteLine($"Вторая цифра {(number / 10) % 10}");
}