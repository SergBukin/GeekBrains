// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] array = new int[3, 4];

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // i < 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //j < 4
        {
            System.Console.Write($"{matrix[i, j]} "); 
        }
    System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 10); //[0, 10)
        }
    }
}

FillArray(array); 
PrintArray(array);

System.Console.WriteLine("Введите последовательно индексы элемента двумерного массива");
int i = int.Parse(Console.ReadLine());
int j = int.Parse(Console.ReadLine());

void FindElementOfIndex(int[,] col)
{
 if(i < col.GetLength(0) && j < col.GetLength(1))
 {
    System.Console.WriteLine($"-> {col[i, j]}");
 }
 else
 {
    System.Console.WriteLine("-> такого числа в массиве нет");
    System.Console.WriteLine("* помни первый индекс в массиве 0 ;)");
 }
}



FindElementOfIndex(array);