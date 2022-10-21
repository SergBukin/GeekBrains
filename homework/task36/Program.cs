// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(0, 10);
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

int SumOfOdds(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    int sum = 0;
 
  while(index < length)
    {
        if(index % 2 != 0)
        {
        sum = sum + numbers[index];
        }
        index++;
    }
    return sum;
}


int[] array = new int[4];

FillArray(array);
PrintArray(array);

int sum = SumOfOdds(array);

System.Console.WriteLine();
System.Console.WriteLine(sum);