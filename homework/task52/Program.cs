// Задача 52.  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.WriteLine("Задайте двумерный массив");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

double[,] array = new double[n, m];

double[,] FillArray(int n, int m)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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


// double[] GetAverageOfColumns(double[,] matrix) // * cреднеарифметическое столбцов в двумерном массиве
// {
//     double[] columns = new double[matrix.GetLength(1)];
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             columns[j] += matrix[i, j];
//         }
//         columns[j] /= matrix.GetLength(0);
//     }

//     return columns;
// }

void PrintAverageOfColumns(double[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i]}; ");
    }
}


double[] GetAverageOfRows(double[,] origin) // * cреднеарифметическое строк в двумерном массиве
{
    double[] result = new double[origin.GetLength(0)];
    for (int i = 0; i < origin.GetLength(0); i++)
    {
        for (int j = 0; j < origin.GetLength(1); j++)
        {
            result[i] += origin[i, j];
        }
        result[i] /= origin.GetLength(1);
    }

    return result;
}

System.Console.WriteLine();
PrintArray(FillArray(n, m));

System.Console.WriteLine();
System.Console.Write("Среднее арифметическое каждого столбца: ");
PrintAverageOfColumns(GetAverageOfRows(array));










