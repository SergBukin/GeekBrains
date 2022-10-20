// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// **********************************************

System.Console.WriteLine("Введите числo N");
int N = int.Parse(Console.ReadLine());
System.Console.WriteLine("Четные числа от 1 до " + N);
for (int i = 1; i < N; i++){
    if(i % 2 == 0)
    System.Console.WriteLine(i);
}

