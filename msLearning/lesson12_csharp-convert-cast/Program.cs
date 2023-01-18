/* 
Шаг 1. Написание кода, пытающегося сложить значения типов int и string, а затем сохранить результат в переменной типа int

    int first = 2;
    string second = "4";
    int result = first + second;
    Console.WriteLine(result);
    Выходные данные

    (3,14): error CS0029: Cannot implicitly convert type 'string' to 'int'


    int first = 2;
    string second = "4";
    string result = first + second;
    Console.WriteLine(result);

    Выходные данные

    24

Шаг 2. Изменение кода в редакторе .NET для выполнения неявного преобразования

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
Выходные данные

int: 3
decimal: 3


decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
Выходные данные

decimal: 3.14
int: 3

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");
Выходные данные

Decimal: 1.23456789
Float: 1.234568

Преобразование числа в строку с помощью метода ToString()

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
Выходные данные

57

Изменение кода в редакторе .NET для преобразования строки в тип int с помощью вспомогательного 
метода Parse():


string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
Выходные данные

12

 Что если любой из переменных first или second будет присвоено значение, которое нельзя преобразовать в int?
Самый простой способ — воспользоваться методом TryParse(), который является улучшенной версией метода Parse(). Мы рассмотрим его на следующем уроке.


Преобразование данных с помощью класса Convert

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

Так когда же следует использовать класс Convert? Класс Convert лучше всего подходит для преобразования 
дробных чисел в целые (int), так как он производит округление надлежащим способом.

    int value = (int)1.5m; // casting truncates
    Console.WriteLine(value);

    int value2 = Convert.ToInt32(1.5m); // converting rounds up
    Console.WriteLine(value2);
    Выходные данные

    1
    2

Упражнение. Метод TryParse()

    string value = "102";
    int result = 0;
    if (int.TryParse(value, out result))
    {
        Console.WriteLine($"Measurement: {result}");
    }
    else
    {
        Console.WriteLine("Unable to report the measurement.");
    }

Резюме

Метод TryParse() очень полезен. Вот некоторые моменты, которые следует помнить:

    Используйте TryParse() при преобразовании строки в числовой тип данных.
    Метод TryParse() возвращает значение true, если преобразование было выполнено успешно, или false в противном случае.
    Выходной параметр является дополнительным способом возвращения значения методом. В этом случае в выходном параметре возвращается преобразованное значение.
    При передаче аргумента в метод, в котором определен выходной параметр, используйте ключевое слово out.

Задача1:
Бизнес-правила

Правило 1. Если значение является буквенно-цифровым, выполните его объединение, чтобы сформировать сообщение.

Правило 2. Если значение является числовым, прибавьте его, чтобы получить сумму.

Правило 3. Результат должен быть следующим:
Выходные данные

Message: ABCDEF
Total: 68.3



    string[] values = { "12.3", "45", "ABC", "11", "DEF" };

    decimal total = 0m;
    string message = "";

    foreach (var value in values)
    {
        decimal number;
        if (decimal.TryParse(value, out number))
        {
            total += number;
        } else
        {
            message += value;
        }
    }

    Console.WriteLine($"Message: {message}");
    Console.WriteLine($"Total: {total}");

Задача2:

    int value1 = 12;
    decimal value2 = 6.2m;
    float value3 = 4.3f;

    int result1 = Convert.ToInt32((decimal)value1 / value2);
    Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

    decimal result2 = value2 / (decimal)value3;
    Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

    float result3 = value3 / value1;
    Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


*/

