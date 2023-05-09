// using System;
// class Sample{
// static void Main() {
//     Console.WriteLine("Простая программа на C#");
// }
// }
// ******************

// using System;
// class Cicle
// {
//     static void Main()
//     {
//         double radius, area;
//         radius = 10;
//         area = radius * radius * 3.1416;
//         Console.WriteLine("Площадь круга равна = " + area);
//     }

// }
// ****************************
// using System;
// class ForDemo
// {
//     static void Main()
//     {
//         for (int count = 0; count <= 5; count++)
//         {
//             Console.WriteLine("Это подсчет: " + count);
//         }
//         System.Console.WriteLine("Готово !");
//     }
// }
// *********************);

// using System;
// class BlockDemo
// {
//     static void Main()
//     {
//         int i, j, d;
//         i = 2;
//         j = 10;
//         if (i != 0)
//         {
//             d = j / i;
//             System.Console.WriteLine(d);
//         }
//     }
// }
// ************************


using System;
class ProdSum
{
    static void Main()
    {
        int prod;
        int sum; int i;
        sum = 0;
        prod = 1;
        for (i = 1; i <= 10; i++)
        { sum += i; prod *= i; }
        Console.WriteLine("Сумма равна " + sum);
        Console.WriteLine("Произведение равно " + prod);
    }
}