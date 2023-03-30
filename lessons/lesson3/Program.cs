// ФУНКЦИИ (ПРОДОЛЖЕНИЕ)
// ___________________________________________________
// Вид1

// void Method1()
// {
//     System.Console.WriteLine("Author");
// }

// Method1();
// _________________________________________________________
// // Вид2

// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }

// Method2("Text");
// _______________________________________________

// void Method2(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }

// }

// Method2("Text", 4);

// ______________________________________________


// Вид3


// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// System.Console.WriteLine(year);


// Вид4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "text");
// System.Console.WriteLine(res);
// _______________________________________
// ЦИКЛ FOR()
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "text");
// System.Console.WriteLine(res);


// ТАБЛИЦА УМНОЖЕНИЯ

// for(int i = 2; i <= 10; i++)
// {
//   for (int j = 1; j <= 10; j++)
//   {
//    System.Console.WriteLine($"{i} x {j} = {i * j}");
//   }
//   System.Console.WriteLine();
// }
// **********************************************

// Задача РАБОТА С ТЕКСТОМ

// string text = "– Я думаю, – сказал князь, улыбаясь, – что, ежели бы вас послали вместо нашего милого Винценгероде," 
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r


// string Replace(string text, char oldValue, char newValue) 
// {
// string result = string.Empty;
// int length = text.Length; 
// for (int i = 0; i < length; i++)
// {
//   if(text[i] == oldValue) result = result + $"{newValue}";
//   else result = result + $"{text[i]}"; 
// }
//   return result;
// }
// string newText = Replace(text, '–', '|'); 
// Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replace(newText, 'к', 'К'); 
// Console.WriteLine(newText);

// ***********************************
// ЗАДАЧА: УПОРЯДОЧИТЬ МАССИВ

int[] arr = {1, 6, 2, 9, 7, 5, 4, 3, 8};

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}");
  }

System.Console.WriteLine();

}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition  = i;

    for (int j = i + 1; j < array.Length; j++)
    {
        if(array[j] < array[minPosition]) minPosition = j;
    }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);