/* 
Использование методов массивов для сортировки элементов в массиве

Шаг 1. Создание массива палет, а затем их сортировка

..Обратите внимание на строку кода Array.Sort(pallets);. Здесь мы используем метод Sort() класса Array для сортировки элементов в массиве 
в алфавитном порядке.


    string[] pallets = { "B14", "A11", "B12", "A13" };

    Console.WriteLine("Sorted...");
    Array.Sort(pallets);
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

Шаг 2. Изменение порядка палет.

string[] pallets = { "B14", "A11", "B12", "A13" };

    Console.WriteLine("Sorted...");
    Array.Sort(pallets);
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Console.WriteLine("Reversed...");
    Array.Reverse(pallets);
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

Резюме

Вот несколько важных идей, которые мы рассмотрели в этом уроке:

    Класс Array содержит методы, которые могут работать с размером и содержимым массива.
    Используйте метод Sort(), чтобы управлять порядком, основанным на заданном типе данных массива.
    Используйте метод Reverse(), чтобы изменить порядок элементов в массиве на обратный.


Использование методов массивов для очистки массива и изменения его размера.

Метод Array.Clear() позволяет удалять содержимое конкретных элементов в массиве, 
а метод Array.Resize() добавляет или удаляет элементы из нашего массива.

    string[] pallets = { "B14", "A11", "B12", "A13" };
    Console.WriteLine("");

    Array.Clear(pallets, 0, 2);
    Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }


Обратите внимание на строку кода Array.Clear(pallets, 0, 2);. Здесь мы используем метод Array.Clear() для очистки значений, хранящихся в 
элементах массива pallets, начиная с индекса 0 и очищая элементы 2.

Шаг 4.Изменение размера массива для добавления дополнительных элементов

    string[] pallets = { "B14", "A11", "B12", "A13" };
    Console.WriteLine("");

    Array.Clear(pallets, 0, 2);
    Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 6);
    Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

    pallets[4] = "C01";
    pallets[5] = "C02";

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

Обратите внимание на строку Array.Resize(ref pallets, 6);. Здесь вызывается метод Resize(). 
Массив pallets передается в него в качестве аргумента по ссылке с помощью ключевого слова ref.

Шаг 5. Изменение размера массива для удаления элементов.

    string[] pallets = { "B14", "A11", "B12", "A13" };
    Console.WriteLine("");

    Array.Clear(pallets, 0, 2);
    Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 6);
    Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

    pallets[4] = "C01";
    pallets[5] = "C02";

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 3);
    Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }


Можно ли удалить элементы NULL из массива?

Если метод Array.Resize() не удаляет пустые элементы из массива, существует ли еще один вспомогательный метод, который сделает это 
автоматически? Нет. Лучшим способом добиться этого является подсчет количества элементов, отличных от NULL, путем прохода по каждому 
элементу и увеличения переменной (счетчика). Далее следует создать второй массив с размером, равным переменной счетчика. Наконец, 
можно выполнить цикл по каждому элементу в исходном массиве и скопировать значения, отличные от NULL, в новый массив.


Резюме

Вот несколько важных идей, которые мы рассмотрели в этом уроке:

    Используйте метод Clear(), чтобы удалить значения из элементов массива.
    Используйте метод Resize(), чтобы изменить число элементов в массиве, удалив или добавив элементы из конца массива.
    Новые элементы массива и очищенные элементы имеют значение NULL, означающее, что они не указывают на значение в памяти.


Следующий урок: Упражнение. Split() и Join().

Шаг 1. Использование ToCharArray() для изменения порядка строк на обратный

    string value = "abc123";
    char[] valueArray = value.ToCharArray();


Шаг 2. Изменение порядка строк на обратный, а затем объединение массива символов в новую строку

    string value = "abc123";
    char[] valueArray = value.ToCharArray();
    Array.Reverse(valueArray);
    string result = new string(valueArray);
    Console.WriteLine(result);
        Выходные данные

        321cba

Выражение new string(valueArray) создает новый пустой экземпляр класса System.String (который совпадает с типом данных string в C#) и 
передает массив char в качестве конструктора.


Шаг 3. Объединение всех символов в новую строку с разделителями-запятыми с помощью Join


    string value = "abc123";
    char[] valueArray = value.ToCharArray();
    Array.Reverse(valueArray);
    // string result = new string(valueArray);  
    string result = String.Join(",", valueArray);
    Console.WriteLine(result);



Шаг 4. Разделение новой строки с разделителями-запятыми в массив строк.

Наконец, давайте используем метод Split(), доступный для переменных типа string для создания массива строк. 

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

Выходные данные
3,2,1,c,b,a
3
2
1
c
b
a


Задача 1.

    string pangram = "The quick brown fox jumps over the lazy dog";

    string[] message = pangram.Split(' ');
    string[] newMessage = new string[message.Length];

    for (int i = 0; i < message.Length; i++)
    {
        char[] letters = message[i].ToCharArray();
        Array.Reverse(letters);
        newMessage[i] = new string(letters);
    }

    string result = String.Join(" ", newMessage);
    Console.WriteLine(result);

Резюме

Вот что следует помнить при работе со строками и массивами:

Существует несколько методов и приемов, позволяющих преобразовать строку в массив и обратно.
Для создания массива используйте такие методы, как ToCharArray() и Split().
Чтобы преобразовать массив обратно в одну строку, используйте такие методы, как Join(), 
или создайте новую строку, передав в нее массив char.


Задача 2_1.


    string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
    string[] items = orderStream.Split(',');

    foreach (var item in items)
    {
        if (item.StartsWith("B"))
        {
            Console.WriteLine(item);
        }
    }

2_2

    string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

    string[] items  = orderStream.Split(',');

    for (int i = 0; i < items.Length; i++)
    {
        if (items[i].StartsWith("B")) 
        {
            Console.WriteLine(items[i]);
        }
    }




*/
