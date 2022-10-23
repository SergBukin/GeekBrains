// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите 2 числа:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int result = 1;
for(int i = 0; i < b; i++)
 {
    result = result * a;
 }
System.Console.WriteLine(result);