// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(double[] digits)
{
    int length = digits.Length;
    int index = 0;
    while(index < length)
    {
        System.Console.WriteLine(digits[index]);
        index++;
    }
}

double FindMinNumbers(double[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    double min = numbers[index];
 
  while(index < length)
    {
        if(numbers[index] < min)
        {
        min = numbers[index];
        }
        index++;
    }
    return min;
}

double FindMaxNumbers(double[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    double max = numbers[index];
 
  while(index < length)
    {
        if(numbers[index] > max)
        {
        max = numbers[index];
        }
        index++;
    }
    return max;
}


double[] array = new double[5];

FillArray(array);
PrintArray(array);

System.Console.WriteLine();
System.Console.WriteLine(FindMaxNumbers(array) - FindMinNumbers(array));