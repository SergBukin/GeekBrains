// //int count = int.Parse(Console.ReadLine());
// //
// //Console.WriteLine(GetSum(count));
// //
// //#region Functions
// //int GetSum(int count)
// //{
// //	int sum = 0;
// //
// //	for (int i = 0; i <= count; i++)
// //	{
// //		sum += i;
// 	}

// 	return sum;
// }

// #endregion


//int n = int.Parse(Console.ReadLine());
//Console.WriteLine(count(n));
//int count(int n);

//for (int j = 0; n != 0; j++)
//{
  //  n = n / 10
//}
//return j;

// string input = Console.ReadLine();
// int count = int.Parse(input);

// Console.WriteLine(GetLength(input));

// int GetLength(string input)
// {

// 	return input.Length;
// }



// int count = int.Parse(Console.ReadLine());

// Console.WriteLine(GetFactorial(count));

// int GetFactorial(int count)
// {
//     int result = 1;
// for (int i = 1; i <= count; i++)
// {
// result= i * result;
// }
// 	return result;
// }


// Console.Write("Введите число");
// int Number = int.Parse(Console.ReadLine());
// Console.WriteLine($"Факториал числа {Number} равен:{GetF(Number)}");
// #region Functions
// int GetF(int Number)
// {
//     int F = 1;

//     for (int i = 1; i <= Number; i++)
//     {
//         F = F * i;
//     }

//     return F;
// }

// #endregion


// int number = int.Parse(Console.ReadLine());
// Console.WriteLine(GetFactorial(number));


// int GetFactorial(int number)
// {
// 	if (number <= 1)
// 		return 1;

// 	return number * GetFactorial(number - 1);
// }int


// Massiv();
// void Massiv()
// {
//     int[] N = new int[8];
//         Console.Write("Массив [");
//     for (int i = 0; i < N.Length; i++)
//     {
//         N[i] = new Random().Next(0, 2);
//         Console.Write($"{N[i]}  ");
//     }
//     Console.Write("]");
// }

// int[] a = new int[8];
// FillBinarryArray(a);
// Console.WriteLine(BinarryArrayToString(a));

// void FillBinarryArray (int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = new Random().Next(0, 2);

//     }
// }


// string BinarryArrayToString(int[] a)
// {
//     string result = " ";
//     for (int i = 0; i < a.Length; i++)
//     {
//         result += a[i];

//     }


//     return result;
// }

