/* 
Введение.
Массив — это специальная переменная, которая содержит последовательность связанных элементов данных.
Вам нужно запоминать базовый формат объявления переменной массива.
Для обращения к каждому элементу массива для задания или получения его значения используется отсчитываемый от нуля числовой индекс в квадратных скобках.
Если попытаться обратиться к индексу за пределами массива, возникнет исключение времени выполнения.
Свойство Length предоставляет программный способ для определения количества элементов в массиве.
Объявление нового массива:
    string[] fraudulentOrderIDs = new string[3];

    fraudulentOrderIDs[0] = "A123";
    fraudulentOrderIDs[1] = "B456";
    fraudulentOrderIDs[2] = "C789";

Циклический переход по массиву с помощью foreach:

    string[] names = { "Bob", "Conrad", "Grant" };
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }

    Выходные данные:
    Bob
    Conrad
    Grant


Создание и инициализация массива типа int:
    int[] inventory = { 200, 450, 700, 175, 250 };
    int sum = 0;
    int bin = 0;
    foreach (int items in inventory)
    {
        sum += items;
        bin++;
        Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
    }
    Console.WriteLine($"We have {sum} items in inventory.");

При выполнении этого кода вы должны увидеть следующие выходные данные.

Bin 1 = 200 items (Running total: 200)
Bin 2 = 450 items (Running total: 650)
Bin 3 = 700 items (Running total: 1350)
Bin 4 = 175 items (Running total: 1525)
Bin 5 = 250 items (Running total: 1775)
We have 1775 items in inventory.


Задача1.

    string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

    foreach (string orderID in orderIDs)
    {
        if (orderID.StartsWith("B"))
        {
            Console.WriteLine(orderID);
        }
    }


Задача2.

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");


*/