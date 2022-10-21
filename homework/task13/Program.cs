// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    int coef = 10;

    if (number > 999)
    {
        while (true)
        {
            int sep = number / coef;

             if (sep > 100 && sep < 1000)
            {
               break;
            }
            else
            {
              coef *= 10;
            }
        }
        System.Console.WriteLine($"Третья цифра {(number / coef) % 10}");
    }
    
    else
    {
      System.Console.WriteLine($"Третья цифра {number % 10}");
    }
    
}