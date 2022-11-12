/* 
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.WriteLine("Введите количество строк 1 массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1 массива: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество строк 2 массива: ");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2 массива: ");
int l = int.Parse(Console.ReadLine());

bool condition = false;
if (n == k) condition = true;

if (!condition)
{
    Console.WriteLine("\nВнимание!Такие матрицы перемножать нельзя! Количество столбцов 1-ой матрицы должно быть ровно количеству строк 2-ой!");
    return;
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    int minValue = 0;
    int maxValue = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue);
        }

    }
    return result;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMultiplicationOfMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

int[,] martixA = GetArray(m, n);
int[,] matrixB = GetArray(k, l);

PrintArray(martixA);
Console.WriteLine();

PrintArray(matrixB);

Console.WriteLine("\nРезультирующая матрица будет:");
PrintArray(GetMultiplicationOfMatrix(martixA, matrixB));