// Использование bool(true/false) 

// string p = "12321";
// bool isPolindrom = true;

// for (int i = 0; i < p.Length; i++)
// {
// 	if (p[i] != p[p.Length - 1 - i])
// 	{
// 		isPolindrom = false;
// 	}
// }

// if (isPolindrom)
// {
// 	Console.WriteLine($"{p} is polindrom");
// }
// else
// {
// 	Console.WriteLine($"{p} is not polindrom");
// }

// *************************************************************

//  ЛУЧШЕ ДЛЯ ПЕРЕБОРА МАССИВА ИСПОЛЬЗОВАТЬ ЦИКЛ for ():

// for (int i = 0; i < length; i++)
// {
    
// }

// *************************************************
// Задать 2-х мерный массив из чисел m, n (вводит пользователь)

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
// PrintArray(GetArray(m,n));

// *************************************************************************


// int[,] array = new int[4, 5];

// string ArrayToString(int[,] array)
// {
// 	string result = string.Empty;

// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			result += $"{array[i, j]} ";
// 		}

// 		result += Environment.NewLine;
// 	}

// 	return result;
// }

// System.Console.WriteLine(ArrayToString(array));



// *****************************************************

// Задать 2-х мерный массив из чисел m, n (вводит пользователь)

// Задача 48. Задайте двумерный массив, размером m на n , каждый элемент в массиве находится по формуле: Amn = m + n;
// Выведите полученный результат на экран.
// m =3, n = 4.
// 0 1 2 3 
// 1 2 3 4 
// 2 3 4 5

Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n)

{
    int[,] array = new int[m, n];
  
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
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
           Console.Write($"{array[i,j]} ");
        }
       Console.WriteLine();
    } 
    
}
PrintArray(GetArray(m,n));

// ***********************************************************

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// ___________________________________________________
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
//  for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if((i + 1) % 2 == 0 && (j + 1) % 2 == 0 )
//             {
//                 array[i, j] = (int) Math.Pow(array[i, j], 2);
//             }
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
//            Console.Write($"{array[i,j]} ");
//         }
//        Console.WriteLine();
//     } 
    
// }
// int [,] array1 = GetArray(m,n);
// PrintArray(array1);
// PrintArray(UpdateArray(array1));

// ______________________________________

// int[,] array = new int[5, 5];

// int[,] UpdateArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		if ((i + 1) % 2 == 0)
// 		{
// 			for (int j = 0; j < array.GetLength(1); j++)
// 			{
// 				if ((j + 1) % 2 == 0)
// 				{
// 					array[i, j] = (int)Math.Pow(array[i, j], 2);
// 				}
// 			}
// 		}
// 	}

// 	return array;
// }

// ****************************************************************************

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// int[,] matrix = new int[3, 5];

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10); //[0, 10)
//         }
//     }
// }

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // i < 3
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //j < 4
//         {
//             System.Console.Write($"{matr[i, j]} "); 
//         }
//     System.Console.WriteLine();
//     }
// }

// int GetDiaganolSumm(int[,] array)
// {
// 	int sum = 0;

// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			if (i == j)
// 				sum += array[i, j];
// 		}
// 	}

// 	return sum;
// }

// FillArray(matrix);
// PrintArray(matrix);

// System.Console.WriteLine(GetDiaganolSumm(matrix));
