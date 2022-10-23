// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координаты первой точки: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());

int[] p1 = new int[] {x1, y1, z1};

System.Console.WriteLine("Введите координаты первой точки: ");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

int[] p2 = new int[] {x2, y2, z2};

double result = Math.Sqrt(Math.Pow((p1[0] - p2[0]), 2))+ Math.Pow((p1[1] - p2[1]), 2) + Math.Pow((p1[2] - p2[2]), 2);

System.Console.WriteLine(result);