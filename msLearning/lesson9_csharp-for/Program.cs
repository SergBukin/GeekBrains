/* 
Шаг 1. Написание простейшего оператора for
Приведенный ниже код — это простой оператор for, который проходит по блоку кода десять раз и выводит текущее значение i:
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
    }

Шаг 2. Изменение условий итерации
Что если счет итераций блока кода должен вестись в обратном порядке?
    for (int i = 10; i >= 0; i--)
    {
        Console.WriteLine(i);
    }

Шаг 3. Настройка шаблона итератора
Что если некоторые значения переменной-итератора должны пропускаться?
    for (int i = 0; i < 10; i += 3)
    {
        Console.WriteLine(i);
    }

Шаг 4. Разбиение оператора итерации с помощью ключевого слова break
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
        if (i == 7) break;
    }

Шаг 5. Перебор элементов массива
    string[] names = { "Alex", "Eddie", "David", "Michael" };
    for (int i = names.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(names[i]);
    }

Шаг 6. Ограничение оператора foreach

    string[] names = { "Alex", "Eddie", "David", "Michael" };
    foreach (var name in names)
    {
        // Can't do this:
        if (name == "David") name = "Sammy";
    }

Выходные данные

Cannot assign to name because it is a 'foreach iteration variable'
Иными словами, переменной name нельзя присвоить другое значение, так как она является частью внутренней реализации итерации foreach.

Шаг 7. Преодоление ограничения оператора foreach с помощью оператора for

    string[] names = { "Alex", "Eddie", "David", "Michael" };
    for (int i = 0; i < names.Length; i++)
        if (names[i] == "David") names[i] = "Sammy";

    foreach (var name in names) Console.WriteLine(name);

Кроме того, можно заметить, что в этом примере кода фигурные скобки убраны, так как блок кода содержит всего одну строку. 



Задача1

Условия FizzBuzz:

    Необходимо вывести значения от 1 до 100, по одному в каждой строке.
    Если текущее значение делится на 3, рядом с числом выводится слово Fizz.
    Если текущее значение делится на 5, рядом с числом выводится слово Buzz.
    Если текущее значение делится как на 3, так и на 5, рядом с числом выводится слово FizzBuzz.


    for (int i = 1; i < 101; i++)
    {
        if ((i % 3 == 0) && (i % 5 == 0))
            Console.WriteLine($"{i} - FizzBuzz");
        else if (i % 3 == 0)
            Console.WriteLine($"{i} - Fizz");
        else if (i % 5 == 0)
            Console.WriteLine($"{i} - Buzz");
        else
            Console.WriteLine($"{i}");
    }


*/