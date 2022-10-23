// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size, int min, int max)
{
	int[] array = new int[size];
	Random rnd = new Random();

	for (int i = 0; i < size; i++)
	{
		array[i] = rnd.Next(min, max);
	}

	return array;
}

string ArrayToString(int[] array)
{
	string result = "[";

	foreach (int item in array)
	{
		result += $"{item}, ";
	}

	result.Trim(',');
	result += "]";

	return result;
}

int[] array = CreateArray(8, -10, 10);

Console.WriteLine(ArrayToString(array));
