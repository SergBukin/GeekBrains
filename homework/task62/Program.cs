/* 
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// using System;

// class Program {
//   public static void Main (string[] args) {

Console.WriteLine($"Введите размер матрицы: ");
    int arraySize = int.Parse(Console.ReadLine());
    int[,] digits = GetArray(arraySize);
    PrintArray(digits);


    int[,] GetArray(int size)
    {
      int [,] result = new int[size, size];
      int i = 0;
      int j = 0;
      int maxNumberOfRow = size - 1;
      int maxNumberOfColumn = size - 1;
      int currentRow = 0;
      int currentColumn = 0;
      bool left = true;
      bool top = true;
      int count = 0;
      while (count < size * size)
      {
        count++;
        result[i, j] = count;
        //идем вправо
        if (left && top)
        {
          if (j == maxNumberOfColumn)
          {
            currentRow++;
            top = true;
            left = false;
            i++;
            continue;
          }
          else
          {
            j++;
              continue;
          }
        }
        //идем вниз
        if (!left && top)
        {
          if (i == maxNumberOfRow)
          {
            maxNumberOfColumn--;
            top = false;
            left = false;
            j--;
            continue;
          }
          else
          {
            i++;
            continue;
          }
        }
        //идем влево
        if (!left && !top)
        {
          if (j == currentColumn)
          {
            maxNumberOfRow--;
            top = false;
            left = true;
            i--;
            continue;
          }
          else
          {
            j--;
            continue;
      }
    }
        //Идем вверх
       if (left && !top)
        {
          if (i == currentRow)
          {
            currentColumn++;
            top = true;
            left = true;
            j++;
            continue;
          }
          else
          {
            i--;
            continue; 
          }
        }
      }
      return result;
    }
    void PrintArray(int[,] inArray)
    {
      for (int i = 0; i < inArray.GetLength(0); i++)
      {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
          Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
      }
    }
//   }
// }