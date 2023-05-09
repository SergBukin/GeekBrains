// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// ****************************************************

System.Console.WriteLine("Введите числа A, B и C");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.Write("max = " + max);
// Console.Write(max);