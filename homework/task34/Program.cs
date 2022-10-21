// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(100, 999);
        index++;
    }
}

void PrintArray(int[] digits)
{
    int length = digits.Length;
    int index = 0;
    while(index < length)
    {
        System.Console.WriteLine(digits[index]);
        index++;
    }
}

int FindEvenNumbers(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    int count = 0;
 
  while(index < length)
    {
        if(numbers[index] % 2 == 0)
        {
        count = count + 1;
        }
        index++;
    }
    return count;
}


int[] array = new int[4];

FillArray(array);
PrintArray(array);

int count = FindEvenNumbers(array);

System.Console.WriteLine();
System.Console.WriteLine("Количество чётных чисел = " + count);