﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// ****************************************************
System.Console.WriteLine("Введите 2 числа");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;

if (numberA > numberB)
{
    max = numberA;
    min = numberB;
} 
else
{
    max = numberB;
    min = numberA;
}
System.Console.WriteLine("min:" + min + ", max:" + max);