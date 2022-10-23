// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите 5-значное число");
string number = Console.ReadLine();

if(number[0] == number[4] && number[1] == number[3])
{
    System.Console.WriteLine("да");
}
else
{
System.Console.WriteLine("нет");
}

