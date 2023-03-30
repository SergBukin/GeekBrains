// string[,] table = new string[2,5];
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// ****************************************************************

// void PrintArray(int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         Console.Write($" {matr[i, j]}");
//     }
//     Console.WriteLine();
// }
// }


// void FillArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[3, 5];
// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix);
// ***************************************************************
// АЛГОРИТМ ЗАКРАШИВАНИЯ ОБЛАСТИ 

// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] pic)
// {
//     for (int i = 0; i < pic.GetLength(0); i++)
//     {
//         for (int j = 0; j < pic.GetLength(1); j++)
//         {
//             if(pic[i, j] ==0) Console.Write(" ");
//             else Console.Write("+");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)
// {
//     if(pic[row, col] ==0)
//     {
//         pic[row, col] =1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }

// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);

// ********************************************************

// double Factorial(int n)
// {
//     if (n == 0) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 0; i < 40; i++)
// {
//     System.Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// *******************************************************

// double Fibonacchi(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacchi(n - 1) + Fibonacchi(n - 2);
// }

// for (int i = 1; i < 40; i++)
// {
//     System.Console.WriteLine($"f({i}) = {Fibonacchi(i)}");
// }
// ***********************************************************

// int af = -5;
// int uf = 5;
// Console.WriteLine($"{af} .. {uf}");

// *******************************

// bool isEven(int value)
// {
//     return value % 2 == 0;
// }
// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{i} = {isEven(i)}");
// }
// ************************************************

// * bool IsEven(int value) => value % 2 == 0;
// ** var IsEven = (int v) => v % 2 ==0;

// var IsEven = (int v) => v % 2 == 0;

// for (int i = 0; i <= 10; i++)
// {
//     System.Console.WriteLine($"{i} = {IsEven(i)}");
// }

//GetMethodAsinc
// **********************************************************

// int a = 12;
// System.Console.WriteLine(a.GetType().Name);
// ************************************

// string caption = "Intensive C# Demo text";
// int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
// int screenHeightPosition = (Console.WindowHeight / 2);
// DrawText(caption, screenWidthPosition, screenHeightPosition);

// DrawText(
//     text: caption,
//     left: screenWidthPosition,
//     top: screenHeightPosition
// );
// ****************************************


// public Roots Solve(double a, double b, double c)
// {
//     var d = b * b - 4 * a * c;
//     double x1 = (-b + Math.Sqrt(d) / (2 * a));
//     double x2 = (-b + Math.Sqrt(d) / (2 * a));
//     return new Roots { X1 = x1, X2 = x2 };
// }

// ******************************************************

// Random rnd = new Random();

// Console.CursorVisible = false;
// while (true)
// {
//     Console.SetCursorPosition(
//         left: rnd.Next(Console.WindowWidth),
//         top: rnd.Next(Console.WindowHeight)
//     );
//     Console.Write(rnd.Next(10));
//     Thread.Sleep(1000);
// }
// ****************************************************


using System.Linq;
string text = "(1,2) (2,3) (4,5) (6,7)"

                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(text);
Console.WriteLine();

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0)
                .Select(point => (point.x * 10, point.y))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    // Console.WriteLine(data[i]);
    // for (int k = 0; k < data[i].Length; k++)
    // {
    //     Console.WriteLine(data[i][k]);
    // }
    // Console.WriteLine(data[i].x * 10);
    Console.WriteLine(data[i]);
    Console.WriteLine();
}



