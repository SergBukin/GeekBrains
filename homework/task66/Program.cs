/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write(" Задайте значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write(" Задайте значение N: ");
int N = int.Parse(Console.ReadLine());

int SumFor(int a, int b)
{
    int result = a;
    for (int i = a + 1; i <= b; i++)
        result += i;
    return result;
}
System.Console.WriteLine(SumFor(M, N));

// int SumRec(int n)
// {
// if (n == 0) return 0;
// else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumRec(10));





