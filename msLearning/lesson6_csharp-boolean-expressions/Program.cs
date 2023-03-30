/*
Шаг1. Улучшение проверки на равенство строк с помощью встроенных вспомогательных методов строки
Однако если требуется принять неточное совпадение, можно сначала "уплотнить" данные. "Уплотнение" данных означает, 
что вам нужно выполнить некоторую очистку, прежде чем проводить сравнение на равенство.
    string value1 = " a";
    string value2 = "A ";
    Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
Чтобы уплотнить две строки перед проверкой на равенство, нужно сделать следующее:

    Убедитесь, что обе строки состоят только из прописных или только из строчных букв, используя вспомогательный метод ToUpper() для значений обоих строк.
    Удалите начальные или конечные пробелы каких-либо строковых значений, используя вспомогательный метод Trim().


Методы, возвращающие логическое значение.


    string pangram = "The quick brown fox jumps over the lazy dog.";
    Console.WriteLine(pangram.Contains("fox"));
    Console.WriteLine(pangram.Contains("cow"));

    Выходные данные:
    True
    False

 * Примечание

Некоторые типы данных имеют методы, выполняющие полезные служебные задачи. В типе данных String их много. Некоторые 
возвращают логическое значение, включая Contains(), StartsWith() и EndsWith().


Что такое логическое отрицание?

    // These two lines of code do the same thing:

    Console.WriteLine(pangram.Contains("fox") == false);
    Console.WriteLine(!pangram.Contains("fox"));

Что такое условный оператор?

Условный оператор?:, который обычно называют тернарным условным оператором, вычисляет логическое выражение и 
возвращает результат вычисления одного из двух выражений в зависимости от того, дает ли логическое выражение 
результат true или false.

Ниже приведена основная форма:

    <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

Шаг 2. Добавление кода, использующего условный оператор


    int saleAmount = 1001;

    int discount = saleAmount > 1000 ? 100 : 50;

    Console.WriteLine($"Discount: {discount}");

или

    int saleAmount = 1001;
    // int discount = saleAmount > 1000 ? 100 : 50;

    Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


Задача "heads" or "tails"

    Random coin = new Random();
    int flip = coin.Next(0, 2);
    Console.WriteLine((flip == 0) ? "heads" : "tails");

or

Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");


*/