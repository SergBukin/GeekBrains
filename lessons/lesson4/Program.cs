// практика 1
// _________________________________

// int a1 = 2;
// int b1 = 999;
// int c1 = 8;
// int a2 = 1;
// int b2 = 15;
// int c2 = 1;
// int a3 = 1;
// int b3 = 29;
// int c3 = 34;

// int MAX(int arg1, int arg2, int arg3)

// {
// 	int result = arg1;
// 	if(arg2 > result) result = arg2;
// 	if(arg3 > result) result = arg3;
// 	return result;
// }

// int max1 = MAX(a1, b1, c1);
// int max2 = MAX(a2, b2, c2);
// int max3 = MAX(a3, b3, c3);
// int sum = MAX(max1, max2, max3);

// System.Console.WriteLine(sum);
// ****************************************

// практика 2

// int[] array = {4, 32, 35, 4, 15, 4, 17, 88};
// int n  = array.Length;
// int index = 0;
// int find = 4;

// while(index < n)
// {
//     if(array[index] == find)
//     {
//         System.Console.WriteLine(index);
//     }
//      index++;
// }

// ********************************************


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while(index < length) 
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while(position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] massive, int find)
{
    int count = massive.Length;
    int index = 0;
    int position = -1;
    
    while(index < count)
    {
        if(massive[index] == find)
        {
        position = index;
        break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 40);

System.Console.WriteLine(pos);







