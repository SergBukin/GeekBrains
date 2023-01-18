//  Задача 53(код 8_1). Задайте двумерный массив. Напишшите программу, которая меняет местами
//  первую и последнюю строку массива.
// _________________________________________________________________
// Console.WriteLine("enter m: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("enter n: ");
// int n = int.Parse(Console.ReadLine());

// int[,] GetArray(int m, int n)

// {
//     int[,] array = new int[m, n];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(1, 10);
//         }
//     }
//     return array;
// }

// int [,] UpdateArray(int[,] array)
// {
// int temp = 0;

//  for (int i = 0; i < array.GetLength(1); i++)
//     {
//         temp = array[0, i];
//         array[0, i] = array[m-1, i];
//         array[m-1, i] = temp;
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write($"{array[i,j]} ");
//         }
//        Console.WriteLine();
//     } 
    
// }
// int [,] array1 = GetArray(m,n);
// PrintArray(array1);
// System.Console.ReadLine();

// PrintArray(UpdateArray(array1));


// ************************************************
// Задача 53(код 8_2?). Задайте двумерный массив. Напишшите программу, которая меняет местами
//  первую и последнюю строку массива.
// ____________________________________________________________________
// Console.WriteLine("enter m: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("enter n: ");
// int n = int.Parse(Console.ReadLine());
// int[,] FirstArray = GetArray(m, n);
// PrintArray(FirstArray);
// int[] TempArray = new int[n];


// int[,] GetArray(int m, int n)

// {
//     int[,] array = new int[m, n];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }

// void ChangeArray(int [,] array)
// {
//     int[] TempArray = new int[array.GetLength(1)];

//     for (int x = 0; x < array.GetLength(1); x++)
//     {
//         TempArray[x] = array[0, x];
//         array[0, x] = array[array.GetLength(0) - 1, x];
// array[array.GetLength(0) - 1, x] = TempArray[x];

//     }
        

// }

// ***************************************************

// Задача 55. Задайте двумерный массив. Напишите программу, которая меняет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.


// int[,] UpdateArray(int[,] array)
// {
// 	int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

// 	if (array.GetLength(1) != array.GetLength(0))
// 	{
// 		throw new ArgumentException("Thiw array can't be reversed");
// 	}

// 	for (int i = 0; i < array.GetLength(1); i++)
// 	{
// 		int[] column = CopyColumn(array, i);

// 		AddRowToArray(array, newArray, column, i);
// 	}



// 	return newArray;
// }

// int[] CopyColumn(int[,] array, int columnNumber)
// {
// 	int[] coulumn = new int[array.GetLength(0)];

// 	for (int i = 0; i < coulumn.Length; i++)
// 	{
// 		coulumn[i] = array[columnNumber, i];
// 	}

// 	return coulumn;
// }

// void AddRowToArray(int[,] originArray, int[,] copiedArray, int[] row, int rowNumber)
// {
// 	for (int i = 0; i < originArray.GetLength(0); i++)
// 	{
// 		copiedArray[i, rowNumber] = row[i];
// 	}
// }

// int[,] CreateArray(int m, int n)
// {
// 	int[,] array = new int[m, n];

// 	Random random = new Random();

// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			array[i, j] = random.Next(1, 20);
// 		}
// 	}

// 	return array;
// }

// void PrintArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] + " ");
// 		}
// 		Console.WriteLine();
// 	}
// }

// int[,] array = CreateArray(5, 5);
// PrintArray(array);

// Console.WriteLine();

// int[,] newArray = UpdateArray(array);
// PrintArray(newArray);

// ************************************************

// Задача 57. Составить частотный словарь элементов двумерного массива, Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.



// **************************************************************

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// using System;

// Console.WriteLine("enter m: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("enter n: ");
// int n = int.Parse(Console.ReadLine());
// int[,] Array = CreateArray(m, n);


// int[,] CreateArray(int m, int n)
// {
//     int[,] array = new int[m, n];

//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(1, 20);
//         }
//     }

//     return array;
// }

// int[,] UpdateArray(int[,] array, int[] coordinates)
// {
//     int[,] SmallArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if ( i!= coordinates[0] || j!= coordinates[1])
//             {
//                 SmallArray[i, j] = array[i, j];                                
//             }                
//         }
//     }

//     return array;
// }

// // Поиск мин. значения
// int [] MinElement(int[,] array)
// {
//     int xmin = 0;
//     int ymin = 0;
//     int min = array[0, 0];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min=array[i, j];
//                 xmin = i;
//                 ymin = j;
//             }
//         }
//     }
    
// return new int[] { xmin, ymin };
// }


//     void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }

// *****************************************************************


// int[,] GetDictionary(int[] array)
// {
// 	int[] uniqueArray = GetUniqueValuesCount(array);
// 	int[,] dictionary = new int[uniqueArray.Length, 2];

// 	for (int i = 0; i < uniqueArray.Length; i++)
// 	{
// 		dictionary[i, 0] = uniqueArray[i];
// 	}

// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		dictionary[IndexOf(dictionary, array[i]), 1]++;
// 	}

// 	return dictionary;
// }


// // 1 1 2 3 2 1 4 5 5 6 7
// int[] GetUniqueValuesCount(int[] array)
// {
// 	List<int> uniqueValues = new List<int>();

// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		if (!uniqueValues.Contains(array[i]))
// 		{
// 			uniqueValues.Add(array[i]);
// 		}
// 	}

// 	return uniqueValues.ToArray();
// }

// int IndexOf(int[,] array, int number)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		if (array[i, 0] == number)
// 		{
// 			return i;
// 		}
// 	}

// 	return -1;
// }

// int[] CreateArray(int length)
// {
// 	int[] array = new int[length];
// 	Random random = new Random();

// 	for (int i = 0; i < length; i++)
// 	{
// 		array[i] = random.Next(1, 11);
// 	}

// 	return array;
// }

// void PrintArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] + " ");
// 		}
// 		Console.WriteLine();
// 	}
// }

// void PrintOneDimensionArray(int[] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		Console.Write(array[i] + " ");
// 	}
// 	Console.WriteLine();
// }

// int[] array = CreateArray(10);
// PrintOneDimensionArray(array);

// PrintArray(GetDictionary(array));

// ********************************************************************************************************
// ********************************************************************************************************

// Задача. Напишите программу, которая удалит строку и  столбец с минимальным элементом массива.

// int[,] RemoveMinColumnsAndRowsFromArray(int[,] array)
// {
// 	int min = array[0, 0];
// 	int min_x = 0;
// 	int min_y = 0;

// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			if (array[i, j] < min)
// 			{
// 				min = array[i, j];
// 				min_x = i;
// 				min_y = j;
// 			}
// 		}
// 	}

// 	int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
// 	int k = 0;

// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		if (i == min_x)
// 		{
// 			if (i < array.GetLength(1) - 1)
// 			{
// 				k = 1;

// 			}
// 			else
// 			{
// 				break;
// 			}
// 		}
// 		else
// 			CopyArrayWithRemovedRow(array, result, min_y, i, k);
// 	}

// 	return result;
// }

// void CopyArrayWithRemovedRow(int[,] originArray, int[,] copiedArray, int removingRow, int column, int columnCoef)
// {
// 	int originCoef = 0;
// 	for (int i = 0; i < originArray.GetLength(1) - 1; i++)
// 	{
// 		if (i == removingRow)
// 		{
// 			if (i < originArray.GetLength(1) - 1)
// 			{
// 				originCoef = 1;
// 			}
// 			else
// 			{
// 				return;
// 			}
// 		}
// 		copiedArray[column - columnCoef, i] = originArray[column, i + originCoef];
// 	}
// }

// int[,] CreateArray()
// {
// 	int[,] array = new int[5, 5];
// 	Random r = new Random();
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			array[i, j] = r.Next(1, 10);
// 		}
// 	}

// 	return array;
// }

// void PrintArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] + " ");
// 		}
// 		Console.WriteLine();
// 	}
// }


// int[,] array = CreateArray();
// PrintArray(array);
// Console.WriteLine();
// PrintArray(RemoveMinColumnsAndRowsFromArray(array));