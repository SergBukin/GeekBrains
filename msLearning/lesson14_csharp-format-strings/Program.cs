/*
В целом разработчики программного обеспечения работают над следующими аспектами:

    Ввод данных -  включая данные, вводимые пользователем с клавиатуры, с помощью мыши, устройства или другой программной системы через сетевой запрос.
    Обработка данных -  включая логику принятия решений, управление данными, выполнение вычислений и т. д.
    Вывод данных -  включая представление для конечного пользователя через сообщение командной строки, окно, веб-страницу или сохранение обработанных данных в файл, их отправку в сетевую службу и т. д.


Что такое составное форматирование?

    string first = "Hello";
    string second = "World";
    Console.WriteLine("{1} {0}!", first, second);
    Console.WriteLine("{0} {0} {0}!", first, second);

    Необходимо учитывать несколько важных моментов в связи с этим кодом.

    Типы данных и переменные определенного типа данных имеют встроенные вспомогательные методы для упрощения некоторых задач.
    Литеральная строка "{0} {1}!" формирует шаблон, части которого будут заменены во время выполнения.
    Маркер {0} заменяется первым аргументом после строкового шаблона, то есть значением переменной first.
    Маркер {1} заменяется вторым аргументом после строкового шаблона, то есть значением переменной second.


Что такое интерполяция строк?

    string first = "Hello";
    string second = "World";
    Console.WriteLine($"{first} {second}!");
    Console.WriteLine($"{second} {first}!");
    Console.WriteLine($"{first} {first} {first}!");


Форматирование валюты?

    decimal price = 123.45m;
    int discount = 50;
    Console.WriteLine($"Price: {price:C} (Save {discount:C})");

Обратите внимание, что при добавлении :C к маркерам внутри фигурных скобок число форматируется как валюта независимо от 
того, используется ли int или decimal.

Форматирование чисел?

При работе с числовыми данными может потребоваться отформатировать число для удобства чтения, включив запятые, чтобы обозначить тысячи, миллионы, миллиарды и т. д.

Это будет сделано с помощью описателя числового формата N.


    decimal measurement = 123456.78912m;
    Console.WriteLine($"Measurement: {measurement:N} units");

Форматирование процентов?

Вы можете использовать описатель формата P для форматирования процентов. Добавьте число, чтобы управлять количеством 
значений, отображаемых после десятичной запятой.

    decimal tax = .36785m;
    Console.WriteLine($"Tax rate: {tax:P2}");

Bесь код для упражнения должен выглядеть следующим образом:

    int invoiceNumber = 1201;
    decimal productMeasurement = 25.4568m;
    decimal subtotal = 2750.00m;
    decimal taxPercentage = .15825m;
    decimal total = 3185.19m;

    Console.WriteLine($"Invoice Number: {invoiceNumber}");
    Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
    Console.WriteLine($"     Sub Total: {subtotal:C}");
    Console.WriteLine($"           Tax: {taxPercentage:P2}");
    Console.WriteLine($"     Total Due: {total:C}");

    Выходные данные

    Invoice Number: 1201
    Measurement: 25.457 mg
        Sub Total: ¤2,750.00
            Tax: 15.83 %
        Total Due: ¤3,185.19

Упражнение. Заполнение и выравнивание?


Ниже приведен краткий список категорий этих встроенных методов.

    Методы, которые добавляют пробелы в целях форматирования (PadLeft(), PadRight())

    Методы, которые либо сравнивают две строки, либо упрощают сравнение (Trim(), TrimStart(), TrimEnd(), GetHashcode(), свойство Length)

    Методы, помогающие определить, что находится внутри строки, или даже получить только часть строки (Contains(), StartsWith(), EndsWith(), Substring())

    Методы, изменяющие содержимое строки путем замены, вставки или удаления частей (Replace(), Insert(), Remove())

    Методы, которые превращают строку в массив строк или символов (Split(), ToCharArray())

Форматирование строк путем добавления пробелов в начале или в конце?

    string input = "Pad this";
    Console.WriteLine(input.PadLeft(12, '-'));
    Console.WriteLine(input.PadRight(12, '-'));

Задача: 
    string paymentId = "769";
    string payeeName = "Mr. Stephen Ortega";
    string paymentAmount = "$5,000.00";

    var formattedLine = paymentId.PadRight(6);
    formattedLine += payeeName.PadRight(24);
    formattedLine += paymentAmount.PadLeft(10);

    Console.WriteLine(formattedLine);

Поскольку очень трудно считать столбцы, где отображается каждый элемент данных, давайте добавим строку непосредственно над выходными данными, чтобы обозначить столбцы.

    string paymentId = "769";
    string payeeName = "Mr. Stephen Ortega";
    string paymentAmount = "$5,000.00";

    var formattedLine = paymentId.PadRight(6);
    formattedLine += payeeName.PadRight(24);
    formattedLine += paymentAmount.PadLeft(10);

    Console.WriteLine("1234567890123456789012345678901234567890");
    Console.WriteLine(formattedLine);

    Выходные данные

    1234567890123456789012345678901234567890
    769   Mr. Stephen Ortega       $5,000.00


    Тип данных string, строки литералов и переменные строкового типа реализуют множество вспомогательных методов для форматирования, изменения и выполнения других операций со строками.
    Методы PadLeft() и PadRight() добавляют пробелы (или другие символы) к строке, чтобы она стала нужной длины.
    Вы можете использовать PadLeft(), чтобы выровнять строку по правому краю.
    Некоторые методы перегружены, то есть имеют несколько версий с разными аргументами, которые влияют на функциональность.
    Оператор += объединяет новую строку справа от существующей строки слева.
    Задача.

    string customerName = "Mr. Jones";

    string currentProduct = "Magic Yield";
    int currentShares = 2975000;
    decimal currentReturn = 0.1275m;
    decimal currentProfit = 55000000.0m;

    string newProduct = "Glorious Future";
    decimal newReturn = 0.13125m;
    decimal newProfit = 63000000.0m;

    Console.WriteLine($"Dear {customerName},");
    Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
    Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
    Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

    Console.WriteLine("Here's a quick comparison:\n");

    string comparisonMessage = "";

    comparisonMessage = currentProduct.PadRight(20);
    comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
    comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

    comparisonMessage += "\n";
    comparisonMessage += newProduct.PadRight(20);
    comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
    comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

    Console.WriteLine(comparisonMessage);


*/



