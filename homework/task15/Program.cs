// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите день недели ");
int day = int.Parse(Console.ReadLine());

if(day <= 5)
  {
  System.Console.WriteLine("нет");
  }
  else
  {
  System.Console.WriteLine("да");
  }
