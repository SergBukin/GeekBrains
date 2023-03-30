// Задача 63. Задайте значение N. Напишите прграмму, которая выведет все натуральные числа в промежутке от 1 до N.

// Console.WriteLine("enter m: ");
// int m = int.Parse(Console.ReadLine());

// void FindNumber (int a)
// {
//  if (a == 1) {System.Console.WriteLine(a); return;}   
// FindNumber (a-1);
// System.Console.WriteLine(a);
// }

// FindNumber(m);
// ********************************************************************************
// *********************************************************************************
// Задача 64. Задайте значения M и N. Напишите прграмму, которая выведет все натуральные числа в промежутке от M до N.

// Console.WriteLine("enter n: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("enter m: ");
// int m = int.Parse(Console.ReadLine());


// void FindNumber (int a, int b)
// {
//  if (a > b) {System.Console.WriteLine("Ошибка ввода"); return;}
//  else 
//  if (a == b) {System.Console.WriteLine(a); return;}   
// FindNumber (a, b-1);
// System.Console.WriteLine(b);
// }

// FindNumber(n, m);

// ********************************************************************************
// *********************************************************************************

// using System.Text;

// StringBuilder GetNumbers(int i, StringBuilder sb = null)
// {
// 	if (sb is null)
// 	{
// 		sb = new StringBuilder();
// 	}

// 	if (i == 1)
// 	{
// 		sb.Append(i.ToString() + " ");
// 		return sb;
// 	}

// 	GetNumbers(i - 1, sb);
// 	sb.Append(i.ToString() + " ");

// 	return sb;
// }

// Console.WriteLine(GetNumbers(5).ToString());


// *************************************************************
// *************************************************************

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("enter m: ");
// int m = int.Parse(Console.ReadLine());

// int digitsSum(int N)
// {
//     if (N / 10 == 0) return N;
//     return N % 10 + digitsSum(N / 10);
// }

// System.Console.WriteLine(digitsSum(m));

// ********************************************************

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.WriteLine("enter A: ");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("enter B: ");
// int B = int.Parse(Console.ReadLine());

// int degreeNatural (int a, int b)
// {
//     if (b == 0) return a;
//     return degreeNatural (a, b-1) * a;
// }

// System.Console.WriteLine(degreeNatural(A, B));

// ********************************************************