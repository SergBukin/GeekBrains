// Задача 39. Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте,
//  а первый - на последнем и т.д. )
// [1 2 3 4 5] ->[5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// ___________________________________________________________________________
// string ArrayToString(int[] array)
// {
//     string result = string.Empty;

//     for (int i = 0; i < array.Length; i++)
//     {
//         result += $"{array[i]}, ";
//     }
//     return result;
// }

// int[] TransporateArray(int[] originArray)
// {

//     int[] newArray = new int[originArray.Length];
//     for (int i = 0; i < originArray.Length; i++)
//     {
//         newArray[i] = originArray[originArray.Length - 1 - i];
//     }
//     return newArray;

// }

// void Transporate(int[] originArray)
// {
//     for (int i = 0; i < originArray.Length / 2; i++)
//     {
//         int buffer = originArray[i];
//         originArray[i] = originArray[originArray.Length - 1 - i];
//         originArray[originArray.Length - 1 - i] = buffer;
//     }

// }

// int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// System.Console.WriteLine(ArrayToString(array));

// int[] newarray = TransporateArray(array);
// System.Console.WriteLine(ArrayToString(newarray));

// Transporate(array);
// System.Console.WriteLine(ArrayToString(array));

// *********************************************************


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длинны.

// int[] triangl = new int[3];

// int[] Getsizes(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.WriteLine($"Введите {i + 1}");
//         triangl[i] = int.Parse(Console.ReadLine());
//     }
//     return array;
// }
// void Proverka(int[] array) // ДОБАВИТЬ ПРОВЕРКУ РАВНОСТОРОННЕГО ТРЕУГОЛЬНИКА    
// {
//     int max = array[0];
//     int j = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (max < array[i])
//         {
//             j = i;
//             max = array[i];
//         }
//     }
//     int sum = 0;
//     foreach (int item in array)
//     {
//         if (item != max) sum = sum + item;
//     }
//     if (sum > max) System.Console.WriteLine("Треугольник возможен");
//     else System.Console.WriteLine("Треугольник не возможен");
// }


// Getsizes(triangl);
// Proverka(triangl);
// int chislo;
// System.Console.WriteLine();

// Задача 42: Напишите программу, которая бутет преобразовывать десятичное число в двоичное.
// 445 -> 101101
// 3 -> 11
// 2 -> 10

// ____________________________________________________________
// string DecNumber(int number)
// {
//     string result = string.Empty;
//     while(number > 0)
//     {
//         result += number %2;
//         number /= 2;
//     }
//     return result;
// }

// System.Console.WriteLine(DecNumber(45));

// *****************************************************

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8 

// Console.WriteLine("Enter your number: ");
// int n = int.Parse(Console.ReadLine());
// int [] array = Fb (n);
// PrintArray (array);

// void PrintArray(int[] array)
// {
// int count = array.Length;

// for (int i = 0; i < count; i++)
// {
// Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// }


// int [] Fb (int n)
// {
// int [] array = new int [n];
// array [0] = 0;
// array [1] = 1;
// for (int i = 2; i < array.Length ; i++)
// {
// array [i] = array [i-1] + array [i-2];


// }
// return array;

// }



// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


// int[] CreateArray(int size)
// {
// int[] array = new int[size];

// for (int i = 0; i < array.Length; i++)
// {
// array[i] = i;
// }

// return array;
// }

// int[] CopyArray(int[] originArray)
// {
// int[] newArray = new int[originArray.Length];

// for (int i = 0; i < newArray.Length; i++)
// {
// newArray[i] = originArray[i];
// }

// return newArray;
// }

// string ArrayToString(int[] array)
// {
// string result = string.Empty;

// for (int i = 0; i < array.Length; i++)
// {
// result += array[i] + " ";
// }

// return result;
// }
// int[] array = CreateArray(10);
// Console.WriteLine(ArrayToString(array));
// Console.WriteLine(ArrayToString(CopyArray(array)));

// _____________________________________________________________

int[] CreateEmptyArrayForFibbonachi(int size)
{
int[] array = new int[size];

array[0] = 0;
array[1] = 1;

return array;
}

string ArrayToString(int[] array)
{
string result = string.Empty;

for (int i = 0; i < array.Length; i++)
{
result += array[i] + " ";
}

return result;
}

int[] GetFibonachi(int[] emptyArray)
{
for (int i = 2; i < emptyArray.Length; i++)
{
emptyArray[i] = emptyArray[i - 1] + emptyArray[i - 2];
}

return emptyArray;
}

int[] fib = CreateEmptyArrayForFibbonachi(8);
fib = GetFibonachi(fib);
Console.WriteLine(ArrayToString(fib));