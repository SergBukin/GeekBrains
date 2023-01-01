/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write(" Задайте значение m: ");
int m = int.Parse(Console.ReadLine());
Console.Write(" Задайте значение n: ");
int n = int.Parse(Console.ReadLine());

int Akkerman(int a, int b)
{
    if (a == 0)
        return b + 1;
    else
      if ((a != 0) && (b == 0))
        return Akkerman(a - 1, 1);
    else
        return Akkerman(a - 1, Akkerman(a, b - 1));
}
Console.WriteLine($"A(m,n) = " + Akkerman(m, n));
