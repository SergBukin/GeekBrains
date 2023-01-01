/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Write(" Задайте значение N: ");
int N = int.Parse(Console.ReadLine());

string Numbers(int a, int b)
{
    if (a <= b) return Numbers(a + 1, b) + $"{a}, ";
    else return String.Empty;
}
Console.WriteLine(Numbers(1, N)); // 10 9 8 7 6 5 4 3 2 1