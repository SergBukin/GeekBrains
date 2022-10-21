//  Знакомство с функциями и массивами
// __________________________________________________
//  Задача №1: Функция Мах
// // ____________________________________________________
// int Max(int x, int y, int z)
// {
//     int result = x;
//     if(y> result) result = y;
//      if(z> result) result = z;
//     return result;
// }

// int a1 = 1;
// int b1 = 2;
// int c1 = 6;

// int a2 = 200;
// int b2 = 3;
// int c2 = 7;

// int a3 = 4;
// int b3 = 5;
// int c3 = 89;

// *int max1 = Max(a1, b1, c1);
// *int max2 = Max(a2, b2, c2);
// *int max3 = Max(a3, b3, c3);

// int max = Max(
//     Max(a1, b1, c1), 
//     Max(a2, b2, c2),
//     Max(a3, b3, c3));

// Console.Write("max = ");
// Console.WriteLine(max);

// // ***************************************
// // Задача №2: Массивы

// // ***ТИП ДАННЫХ[] ИМЯ = {Значение1, Значение2, ...}
// // ***int[] array = {9, 28, 1, 32, 1990}
// // ***int[] array = {0, 0, 0, 0, 0}
// // ***int[] array = new int[5]
// // ***int[] array = new int[5]{9, 28, 1, 32, 1990};
// // _____________________________________________________________

// // int Max(int arg1, int arg2, int arg3)
// // {
// //     int result = arg1;
// //     if(arg2 > result) result = arg2;
// //     if(arg3 > result) result = arg3;
// //     return result;
// // }

// // int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};

// // int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

// // Console.WriteLine(max);

// // *************************************************************
// Задача №2: "Дан массив array, в котором n элементов. Найдём элемент, совпадающий с
// некоторым значением, который определяет пользователь".

// // int[] array = {11, 22, 31, 43, 50, 16, 72, 81};
// // int n = array.Length;
// // int index = 0;
// // int find = 31;

// // while (index < n)
// // {
// //   if (array[index] == find)
// //   System.Console.WriteLine(index);
// //   index++;
// // }

// // **********************************************************

// // Console.Clear();
// // void FillArray(int[] collection)

// // {
// //    int length = collection.Length;
// //    int index = 0;
// //    while (index < length)
// //    {
// //     collection[index] = new Random().Next(1, 10);
// //     index++;
// //    }
// // }
// // void PrintArray(int[] col)
// // {
// //     int count = col.Length;
// //     int position = 0;

// //     while (position < count)
// //     {
// //     System.Console.WriteLine(col[position]);
// //     position++;
// //     }
// // }

// // int IndexOf(int[] collection, int find)
// // {

// //     int count = collection.Length;
// //     int index = 0;
// //     int position = -1;

// //     while (index < count)
// //     {
// //        if(collection[index] == find)
// //        {
// //           position = index;
// //           break;
// //        }
// //         index++;
// //     }
// //     return position;
// // }

// // int[] array = new int[10];

// // FillArray(array);
// // PrintArray(array);

// // System.Console.WriteLine();

// // int pos = IndexOf(array, 4);
// // System.Console.WriteLine(pos);

// //  *************************************

// int[] CreateArray(int size, int min, int max)
// {
// 	int[] array = new int[size];
// 	Random rnd = new Random();

// 	for (int i = 0; i < size; i++)
// 	{
// 		array[i] = rnd.Next(min, max);
// 	}

// 	return array;
// }

// int[] GetReverseArray(int[] array)
// {
// 	int[] reversedArray = new int[array.Length];

// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		reversedArray[i] = -array[i];
// 	}

// 	return reversedArray;
// }

// string ArrayToString(int[] array)
// {
// 	string result = "[";

// 	foreach (int item in array)
// 	{
// 		result += $"{item}, ";
// 	}

// 	result.Trim(',');
// 	result += "]";

// 	return result;
// }

// int[] array = CreateArray(10, -10, 10);

// Console.WriteLine(ArrayToString(array));
// Console.WriteLine(ArrayToString(GetReverseArray(array)));

//  **********************************************************************

// int[] CreateArray(int size, int min, int max)
// {
// 	int[] array = new int[size];
// 	Random rnd = new Random();

// 	for (int i = 0; i < size; i++)
// 	{
// 		array[i] = rnd.Next(min, max);
// 	}

// 	return array;
// }

// int[] GetReverseArray(int[] array)
// {
// 	int[] reversedArray = new int[array.Length];

// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		reversedArray[i] = -array[i];
// 	}

// 	return reversedArray;
// }

// string ArrayToString(int[] array)
// {
// 	string result = "[";

// 	foreach (int item in array)
// 	{
// 		result += $"{item}, ";
// 	}

// 	result += "]";

// 	return result;
// }

// bool FindNumber(int[] array, int number)
// {
// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		if (array[i] == number)
// 			return true;
// 	}

// 	return false;
// }

// int[] array = CreateArray(20, -5, 5);

// int findNumber = int.Parse(Console.ReadLine());

// Console.WriteLine(ArrayToString(array));
// Console.WriteLine(ArrayToString(GetReverseArray(array)));
// Console.WriteLine(FindNumber(array, findNumber));