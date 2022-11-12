/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/

Console.WriteLine("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)

{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    int minValue = 0;
    int maxValue = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int maxPosition = j;
            
            for (int k = j +1; k < arr.GetLength(1); k++)
            {
                if (arr[i,k] > arr[i, maxPosition]) maxPosition = k;
            }
                int temp = arr[i,j];
                arr[i,j] = arr[i,maxPosition];
                arr[i, maxPosition] = temp;
        }
    }
    return arr;
}

int[,] array1 = GetArray(m, n);

PrintArray(array1);

Console.WriteLine();

PrintArray(SortArray(array1));


