/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int[] CalculateSumRaw(int[,] arr)
{
    int[] result = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum+= arr[i,j]; 
        }  
       result[i] = sum;
    }
    return result;
}


void PrintMinRaw(int[] array)
{
    int min = array[0];
    int index  = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
            index = i;
        }
    }
    System.Console.WriteLine($"мин сумма элементов {min}, строка {index+1}");
}

int[,] matrix = GetArray(m, n);

PrintArray(matrix);

Console.WriteLine();

PrintMinRaw(CalculateSumRaw(matrix));

