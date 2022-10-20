// Знакомство с языком программирования C#

// ЗАДАЧА №1: ПРИВЕТСТВИЕ МИРА!
// ______________________________________
// Console.WriteLine("Hello, World!");
// **************************************

// ЗАДАЧА №2: ПРИВЕТСТВИЕ ПОЛЬЗОВАТЕЛЯ!
// __________________________________________________
// Console.WriteLine("Привет, введите ваше имя ");
// string username = Console.ReadLine();
// Console.WriteLine("Привет, ");
// Console.Write(username);
// Console.Write("!");
// *****************************************************

// ЗАДАЧА №3: СЛОЖЕНИЕ 2-Х ЧИСЕЛ!
// _________________________________________
// int numberA = 3;
// int numberВ = 5;
// Console.WriteLine(numberA + numberВ );
// _________________________________________________
// int numberA = 31;
// int numberВ = 5;
// int result = numberA + numberВ;
// Console.WriteLine(result);
// ******************************************************

// ЗАДАЧА №3: ДЕЛЕНИЕ 2-Х ЧИСЕЛ!
// ______________________________________
// int numberA = 10;
// int numberB = 5;
// Console.WriteLine(numberA / numberB);
// _______________________________________

// ".. контейнер «integer» (целое число) заменить на «double», позволяющий работать с вещественными числами. "

// double  numberA = 12;
// double  numberB = 5;
// Console.WriteLine(numberA / numberB);
// *************************************

//  ЗАДАЧА №4: Генератор псевдослучайных чисел 
//  " ..new Random().Next(мin, маx), ГДЕ следующее число в диапазоне от min до max-1.
// ______________________________________________________________________________________
// double numberA = new Random().Next(1,10);
// Console.WriteLine(numberA);
// double numberB = new Random().Next(1,10);
// Console.WriteLine(numberB);

// double result = numberA / numberB;
// Console.WriteLine(result);
// ************************************************

// Задача №5 Код для персонального приветствия
// ______________________________________________________
// System.Console.WriteLine("Введите имя пользователя: ");
// string username = System.Console.ReadLine();
// if(username == "Маша")
// {
// System.Console.WriteLine("Ура, это же МАША");
// }
// else
// {
// System.Console.WriteLine("Привет, ");
// System.Console.WriteLine(username);
// }
// ***************************************************************

// Задача №6: "Код для персонального приветствия".
// ____________________________________________________
// System.Console.WriteLine("Введите имя пользователя: ");
// string username = System.Console.ReadLine();
// if(username.ToLower() == "маша")
// {
// System.Console.WriteLine("Ура, это же МАША!");
// }
// else
// {
// System.Console.WriteLine("Привет, ");
// System.Console.WriteLine(username);
// }
// **************************************************

//  Задача №7: "Программа для решения задачи с гирями"
// ______________________________________________________
// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;
// int max = a;
// if (a > max ) max = a;
// if (b > max ) max = b;
// if (c > max ) max = c;
// if (d > max ) max = d;
// if (e > max ) max = e;
// Console.Write("max = ");
// Console.WriteLine(max);

// ****************************************************

// Задача №7: "Программа, которая будет «рисовать»."
// ___________________________________________________
// Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");
// __________________________________________________________

// Console.Clear();
// int xa = 1, ya = 1, 
// xb = 1, yb = 10,
// xc = 40, yc = 10;
// Console.SetCursorPosition(xa, ya);
// System.Console.WriteLine("+");
// Console.SetCursorPosition(xb, yc);
// System.Console.WriteLine("+");
// Console.SetCursorPosition(xc, yc);
// System.Console.WriteLine("+");
// System.Console.WriteLine();
// System.Console.WriteLine();

// ____________________________________________________________

// Console.Clear();
// int xa = 20, ya = 1,
//     xb = 1, yb = 10,
//     xc = 40, yc = 10;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

// int x = xa, y = xb;

// int count = 0;

// while(count < 10000)
// {
//      int what  = new Random().Next(0,3); //[0;3) 0 1 2
//     if(what == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }

//      if (what == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }

//      if (what == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }
// Console.SetCursorPosition(x, y);
// Console.WriteLine("+");
// count ++;
// }

// ******************************************************