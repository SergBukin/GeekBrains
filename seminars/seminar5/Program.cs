// Разбор домашнего задания
// int[] CreateArray()
// {
//  int[] ints = new int[8];
//  Random random = new Random();
//  for (int i = 0; i < ints.Length; i++)
//  {
//     ints[i] = random.Next();
//  }
//  return ints;
// }

// string GetArrayString(int[] array)
// {
//     string Result = "";
//     for 
// }

// *************************************************************
// int[] CreateArray(int size, int minValue, int MaxValue)
// {
//     int[] array = new int[size];
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(minValue, MaxValue);
//     }
//     return array;
// }

// int GetSumPositiveElementsFromArray(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) sum = sum + array[i];
//     }
//     return sum;
// }

// int GetSumNegativeElementsFromArray(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0) sum = sum + array[i];
//     }
//     return sum;
// }

// string GetArray(int[] array)
// {
//     string sum = string.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         sum = sum + $"{ array[i]}, ";
//     }
//     return sum;
// }

// int[] array  = CreateArray(12, -9, 10);

// System.Console.WriteLine(GetArray(array));
// System.Console.WriteLine("Сумма положительных элементов равна = " + GetSumPositiveElementsFromArray(array));
// System.Console.WriteLine("Сумма отрицательных элементов равна = " + GetSumNegativeElementsFromArray(array));

// *******************************

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

// ************************************************************


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// ________________________________________________________________________

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


// int GetNumbersOfElements(int[] array)
// {
// 	int[] reversedArray = new int[array.Length];
//     int count = 0;
// 	for (int i = 0; i < array.Length; i++)
// 	{
//         int result = array[i];
        
// 		if (result > 10 && result <100)
//         {
//             count++;
//         }
// 	}

// 	return count;
// }
// int[] array = CreateArray(123, -5, 150);

// Console.WriteLine(ArrayToString(array));
// Console.WriteLine(GetNumbersOfElements(array));

// ************************************************************

// int[] CreateArray(int size, int min, int max) 
// { int[] array = new int[size];
//  Random rnd = new Random(); 
//  for (int i = 0; i < size; i++) 
//  { array[i] = rnd.Next(min, max); 
//  }
//     return array;
// }
// int Qelements(int[] array)
// {int counter = 0;
    
//     foreach (int element in array)
//     {
//         if ( element > 9 & element < 99) counter ++;    }
//     return counter;
// }
// string GetArray1(int[] array) 
// { 
//     string sum = string.Empty; 
//     for (int i = 0; i < array.Length; i++) 
//     { 
//         sum = sum + $"{array[i]}, "; 
//     }
        
//          return sum; 
// }
// int[] array = CreateArray(123, -150, 150);
// System.Console.WriteLine(GetArray1(array));
// System.Console.WriteLine(Qelements(array));

// int[] ProzElem(int[] array)

// {
//     int[] arrayP =new int[array.Length/2 +1];
//     int i;
//     for (i =0; i < array.Length/2; i++)
//     {
//         arrayP[i] = array[i]*array[array.Length-i-1];
//     }  
//     if (array.Length % 2 != 0) arrayP[arrayP.Length-1]=array[i];

//     return arrayP;
// }
// array = CreateArray(5, 0, 10);
// System.Console.WriteLine(GetArray1(array));
// System.Console.WriteLine(GetArray1(ProzElem(array)));

// **********************************************************************

// ...Добавка (№2 задание)

// int FilterArray(int[] array, int min, int max)
// {
// 	int count = 0;

// 	for (int i = 0; i < array.Length; i++)
// 	{
// 		if (array[i] > min && array[i] < max)
// 		{
// 			count++;
// 		}
// 	}

// 	return count;
// }

// int[] array = CreateArray(1230, -10, 150);

// //int findNumber = int.Parse(Console.ReadLine());

// Console.WriteLine(ArrayToString(array));
// //Console.WriteLine(ArrayToString(GetReverseArray(array)));
// //Console.WriteLine(FindNumber(array, findNumber));
// Console.WriteLine(FilterArray(array, 9, 100));
